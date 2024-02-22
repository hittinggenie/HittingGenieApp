using Firebase.Auth;

namespace HittingGenie.Pages.VRPHelp;

public partial class VRP1 : ContentPage
{
    public VRP1()
    {
        InitializeComponent();
    }

    
    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Great!", "Let's make sure we are answering the correct questions so we get you back on track. Save your progress and use a VRP for your next few swings. I'll be here waiting. Let me know if you have any additional questions!", "Ok", "Cancel");

        if (response) 
        {
            await SecureStorage.SetAsync("SavePlace", "Pages.VRPHelp.VRPGuide()");
            await Navigation.PopToRootAsync();
        }
    }


    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "What Does This Do?")
        {
            Navigator.IsVisible = false;
            Lbl2.IsVisible = true;
            Lbl3.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }

    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = false;
        NoBtn.IsVisible = false;
        videoPlayer.IsVisible = true;
        Lbl2.IsVisible = false;
        Lbl3.Text = "Please watch the video below.";
        VideoWatched.IsVisible = true;
    }

     void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    async void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new VRPGuide()); } catch (Exception ex) { Console.Write(ex); }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }


}
