namespace HittingGenie.Pages.Settings;
using Firebase.Auth;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}


    async void SignOut_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Profile.SignUp()); SecureStorage.Remove("UID"); } catch (Exception ex) { Console.Write(ex); }
    }

    async void DeleteAcct_Clicked(System.Object sender, System.EventArgs e)
    {
        var authClient = FirebaseSingleton.Instance.AuthClient;
        SecureStorage.Remove("UID");
        var signUpPage = new Pages.Profile.SignUp();
        NavigationPage.SetHasNavigationBar(signUpPage, false); // Hide the navigation bar
        await Navigation.PushAsync(signUpPage);
        /* try
         {
             // Get the current user

             var credential = await authClient.CurrentUser;

             if (user != null)
             {
                 // Delete the user account
                 await user.DeleteAsync();

                 // Remove the UID from SecureStorage
                 SecureStorage.Remove("UID");

                 // Navigate to the sign-up page
                 await Navigation.PushAsync(new Pages.Profile.SignUp());
             }
         }
         catch (Exception ex)
         {
             Console.WriteLine(ex);
         }
     */
    } 

        void ResetPass_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
