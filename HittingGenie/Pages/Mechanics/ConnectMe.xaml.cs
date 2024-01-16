namespace HittingGenie.Pages.Mechanics;

public partial class ConnectMe : ContentPage
{
	public ConnectMe()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        string url = "https://www.trainingkamp.com/contact/";
        await Launcher.OpenAsync(new Uri(url));
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
