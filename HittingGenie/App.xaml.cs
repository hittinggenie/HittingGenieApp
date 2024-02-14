namespace HittingGenie;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        string userUid = SecureStorage.GetAsync("UID").Result;

        if (!string.IsNullOrEmpty(userUid))
        {
            // If the UID exists, set MainPage to the main page
            MainPage = new AppShell();
        }
        else
        {
            // If the UID doesn't exist, set MainPage to a NavigationPage wrapping the login page
            MainPage = new NavigationPage(new Pages.Profile.SignUp());
        }
    }
}
