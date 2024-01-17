

namespace HittingGenie.Pages.Mechanics;

public partial class SoftballRopeVideo : ContentPage
{
	public SoftballRopeVideo()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }

   async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Machine()); } catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

    void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = true;
        Lbl2.IsVisible = true;
        NoBtn.IsVisible = true;
        VideoWatched.IsVisible = false;

    }
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }
}
