namespace HittingGenie.Pages.Mechanics;

public partial class FrontFootLandingVideo : ContentPage
{
	public FrontFootLandingVideo()
	{
		InitializeComponent();
	}

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        Lbl4.IsVisible = true;
        YesBtn.IsVisible = true;
        NoBtn.IsVisible = true;
        Lbl3.IsVisible = false;
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new ConnectMe());   } catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
