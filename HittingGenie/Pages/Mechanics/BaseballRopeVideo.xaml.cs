using Firebase.Auth;

namespace HittingGenie.Pages.Mechanics;

public partial class BaseballRopeVideo : ContentPage
{
	public BaseballRopeVideo()
	{
		InitializeComponent();
	}


    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

     void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
        
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Machine()); } catch (Exception ex) { Console.Write(ex); }
    }

    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Great!", "Your swing should be one fluid motion. Let's save your progress in case you'd like to chat again.", "Save", "Cancel");

        if (response)
        {
            await SecureStorage.SetAsync("SavePlace", "Pages.Mechanics.FluidMotion()");
            
        }
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
