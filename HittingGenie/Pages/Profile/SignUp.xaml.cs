namespace HittingGenie.Pages.Profile;
using Firebase.Auth;
using Firebase.Auth.Providers;


public partial class SignUp : ContentPage
{
    public SignUp()
	{
        
		InitializeComponent();


    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    async void Register_Clicked(System.Object sender, System.EventArgs e)
    {

        try
        {
            if (!ValidateFields())
            {
                errorText.IsVisible = true;
                return;
            }


            var authClient = FirebaseSingleton.Instance.AuthClient;
            var credential = await authClient.CreateUserWithEmailAndPasswordAsync(userEmail.Text, userPass.Text);
            var user = credential.User;
            if (user.Uid != null)
            {
                await SecureStorage.SetAsync("UID", user.Uid);
                Constants.Email = userEmail.Text;
                Constants.IsSignedIn = true;
                //TODO: we want to write this to db 
                await DisplayAlert("Success!", $"Your account has been created. Welcome!", "OK");
                await authClient.SignInWithEmailAndPasswordAsync(userEmail.Text, userPass.Text);
                await Navigation.PushAsync(new MainPage());
            }
        } catch (FirebaseAuthException ex)
        {

            if (ex.Reason == AuthErrorReason.EmailExists)
            {
                errorText.IsVisible = true;
                errorText.Text = "Email is already in use. Please use a different email.";
            }
            if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
            {
                errorText.IsVisible = true;
                errorText.Text = "Please enter a valid email address.";
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    async void Login_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Profile.Login()); } catch (Exception ex) { Console.Write(ex); }
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

        if (string.IsNullOrWhiteSpace(userPass.Text) || string.IsNullOrWhiteSpace(confirmPass.Text))
        {
            errorText.Text = "Please enter both password fields.";
            return false;
        }

        if (userPass.Text != confirmPass.Text)
        {
            errorText.Text = "Passwords do not match.";
            return false;
        }

        
        errorText.Text = string.Empty;

        return true;
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
}