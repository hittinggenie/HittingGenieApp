namespace HittingGenie.Pages;

public partial class BreatheVideo : ContentPage
{
	public BreatheVideo()
	{
		InitializeComponent();
	}


    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

   async void NextStep_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new AreYouBalanced()); } catch (Exception ex) { Console.Write(ex); }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }
}
