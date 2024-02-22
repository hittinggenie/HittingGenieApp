namespace HittingGenie;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        string userUid = SecureStorage.GetAsync("UID").Result;
        string savePlace = SecureStorage.GetAsync("SavePlace").Result;
        if (!string.IsNullOrEmpty(savePlace))
        {
            MainPage = new NavigationPage(new SavePlacePage());
        } else 
        if (!string.IsNullOrEmpty(userUid))
        {
           
            MainPage = new AppShell();
        }
       else  {
           
            MainPage = new NavigationPage(new Pages.Profile.SignUp());
        }
    }


}
