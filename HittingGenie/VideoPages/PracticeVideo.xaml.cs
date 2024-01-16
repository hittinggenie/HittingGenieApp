namespace HittingGenie.VideoPages;

public partial class PracticeVideo : ContentPage
{
	public PracticeVideo()
	{
		InitializeComponent();
	}

    async void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
		try { await Navigation.PushAsync(new Pages.BreatheCorrectly()); }catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }

}
