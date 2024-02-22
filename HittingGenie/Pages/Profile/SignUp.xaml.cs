namespace HittingGenie.Pages.Profile;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;


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
                await WriteUserDataToDatabase(user.Uid, userEmail.Text);
                await DisplayAlert("Success!", "Your account has been created. Welcome!", "OK");
                await authClient.SignInWithEmailAndPasswordAsync(userEmail.Text, userPass.Text);
                await Navigation.PushAsync(new NavigationPage(new MainPage()));
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

    async Task WriteUserDataToDatabase(string uid, string email)
    {
        try
        {
            var firebaseClient = FirebaseSingleton.Instance.FirebaseClient;

            // Define the path where you want to store user data
            var path = $"mobileUsers/{uid}/email";

            // Write user email to the database
            await firebaseClient
                .Child(path)
                .PutAsync(email);
        }
        catch (Exception ex)
        {
            // Handle any errors
            Console.WriteLine($"Error writing user data to database: {ex.Message}");
        }
    }
}