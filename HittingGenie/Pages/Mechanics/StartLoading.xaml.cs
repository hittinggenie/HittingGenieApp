namespace HittingGenie.Pages.Mechanics;

public partial class StartLoading : ContentPage
{
	public StartLoading()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new MakeContact()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.VRPHelp.SendToTiming()); } catch (Exception ex) { Console.Write(ex); }
    }
}
