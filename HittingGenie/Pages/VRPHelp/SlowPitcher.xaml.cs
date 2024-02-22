using Firebase.Auth;

namespace HittingGenie.Pages.VRPHelp;

public partial class SlowPitcher : ContentPage
{
	public SlowPitcher()
	{
		InitializeComponent();
	}

    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Lbl1.Text == "Are you facing a really slow pitcher?")
        {
            Lbl1.Text = "Watch this video on how to best hit slow pitching.";
            videoPlayer.IsVisible = true;
            YesBtn.IsVisible = false;
            NoBtn.IsVisible = false;
            VideoWatched.IsVisible = true;
        }
        else
        {
            ShowPopupMessage();
        }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SendToTiming()); } catch (Exception ex) { Console.Write(ex); }


    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        Lbl1.IsVisible = true;
        Lbl1.Text = "Did this help?";
        YesBtn.IsVisible = true;
        YesBtn.Text = "Yes, Save My Progress";
        NoBtn.IsVisible = true;
    }

    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Nice!", "Your progress has been saved.", "Ok", "Cancel");

        if (response)
        {
            await SecureStorage.SetAsync("SavePlace", "Pages.VRPHelp.SendToTiming()");
            await Navigation.PopToRootAsync();
        }
    }

    void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        Lbl1.IsVisible = true;
        Lbl1.Text = "Did this help?";
        YesBtn.IsVisible = true;
        YesBtn.Text = "Yes, Save My Progress";
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

