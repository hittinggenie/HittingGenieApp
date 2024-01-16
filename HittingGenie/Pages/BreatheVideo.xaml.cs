namespace HittingGenie.Pages;

public partial class BreatheVideo : ContentPage
{
	public BreatheVideo()
	{
		InitializeComponent();
	}

    async void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new AreYouBalanced()); } catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
