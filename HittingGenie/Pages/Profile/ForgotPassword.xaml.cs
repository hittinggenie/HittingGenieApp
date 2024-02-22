using Firebase.Auth;

namespace HittingGenie.Pages.Profile;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
	}

    private async void SendLink_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            if (!ValidateFields())
            {
                errorText.IsVisible = true;
                return;
            }

            var authClient = FirebaseSingleton.Instance.AuthClient;
           

                await authClient.ResetEmailPasswordAsync(userEmail.Text);

             
                await DisplayAlert("Success!", "Please check your e-mail to reset your password.", "Okay");
                await Navigation.PopAsync();
          
        }
        catch (FirebaseAuthException ex)
        {
            errorText.IsVisible = true;
            if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
            {
                errorText.Text = "Please enter a valid email.";
            } else if (ex.Reason == AuthErrorReason.UserNotFound)
            {
                errorText.Text = "Email not found. Try again.";
            }
            else
            {
                errorText.Text = "An error occurred. Please try again.";
                Console.WriteLine("Reason: " + ex.Reason);
            }
        }
        catch (Exception ex)
        {
         
            errorText.Text = ex.Message;
        }
    }

    async void GoBack_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
    private bool ValidateFields()
    {

        if (string.IsNullOrWhiteSpace(userEmail.Text))
        {
            errorText.Text = "Please enter your email.";
            return false;
        }

        if (!IsValidEmail(userEmail.Text))
        {
            errorText.Text = "Please enter a valid email address.";
            return false;
        }


        errorText.Text = string.Empty;

        return true;
    }
}
