namespace HittingGenie.Pages.Profile;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}


    async void SignIn_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Email = userEmail.Text;
        //TODO: Fetch other user info
        await Navigation.PopToRootAsync();
    }
}
