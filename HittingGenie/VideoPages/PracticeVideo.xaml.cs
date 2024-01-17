namespace HittingGenie.VideoPages;

public partial class PracticeVideo : ContentPage
{
	public PracticeVideo()
	{
		InitializeComponent();
	}


    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }

   async void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.BreatheCorrectly()); } catch (Exception ex) { Console.Write(ex); }
    }
}
