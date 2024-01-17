namespace HittingGenie.Pages.VRPHelp;

public partial class NotSureVideo : ContentPage
{
    public NotSureVideo()
    {
        InitializeComponent();
    }


    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Awesome!", "Please select 'Ok' to save your progress. Go take a few swings and come back, and we will pick up from there!", "Ok", "Cancel");

        if (response)
        {
            try { await Navigation.PushAsync(new EarlyOrLate()); } catch (Exception ex) { Console.Write(ex); }

        }
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

    void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }
}


