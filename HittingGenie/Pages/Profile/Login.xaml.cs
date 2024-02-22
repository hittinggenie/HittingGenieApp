namespace HittingGenie.Pages.Profile;
using Firebase.Auth;
public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Hide the navigation bar
        NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);
        
    }


    async void SignIn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
          if (!ValidateFields())
            {
                errorText.IsVisible = true;
                return;
            }
            
            var authClient = FirebaseSingleton.Instance.AuthClient;
            var credential = await authClient.SignInWithEmailAndPasswordAsync(userEmail.Text, userPass.Text);
            var user = credential.User;
            if (user.Uid != null)
            {
                await SecureStorage.SetAsync("UID", user.Uid);
                Constants.Email = userEmail.Text;
                //TODO: Fetch other user info from database
                await DisplayAlert("Success!", "You are now signed in. Welcome back!", "Continue");
                await Navigation.PushAsync(new NavigationPage(new MainPage()));
            }

        } catch (FirebaseAuthException ex) {
            errorText.IsVisible = true;
            if (ex.Reason == AuthErrorReason.UserNotFound)
            {
        
                errorText.Text = "Email does not exist.";
            }

            if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
            {
                errorText.Text = "Please enter a valid email.";
            }

            else if (ex.Reason == AuthErrorReason.WrongPassword)
            {
             
                errorText.Text = "Incorrect password.";
            }
            else
            {
           
                errorText.Text = "An error occurred. Please try signing in again.";
                Console.WriteLine("Reason: " +  ex.Reason);
            }
        }
        catch (Exception ex)
        {
            // Handle general exceptions
            errorText.Text = ex.Message;
        }
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

        if (string.IsNullOrWhiteSpace(userPass.Text))
        {
            errorText.Text = "Please enter your password.";
            return false;
        }


        errorText.Text = string.Empty;

        return true;
    }

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        try { await Navigation.PushAsync(new ForgotPassword()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void GoBack_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PopAsync(); } catch (Exception ex) { Console.Write(ex); }
    }
}


