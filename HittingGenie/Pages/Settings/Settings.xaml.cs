namespace HittingGenie.Pages.Settings;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    async void EditProfile_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new Pages.Profile.ProfileInfo());
    }

    async void SignOut_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Profile.SignUp()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void DeleteAcct_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Profile.SignUp()); } catch (Exception ex) { Console.Write(ex); }
    }

    void ResetPass_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
