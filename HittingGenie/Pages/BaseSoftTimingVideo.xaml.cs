using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
namespace HittingGenie.Pages;

public partial class BaseSoftTimingVideo : ContentPage
{
    public BaseSoftTimingVideo()
    {
        InitializeComponent();
        if (Constants.Sport == "Baseball")
        {
            Lbl1.Text = "Starting to get ready when the pitcher's knee hits its highest point will give you the best chances of seeing the ball and making contact.";
            Lbl2.Text = "Watch the video, then try this and let me know how it goes.";
            SoftballVideo.IsVisible = false;
            mediaElement.IsVisible = true;
           
        }
        else if (Constants.Sport == "Softball")
        {
            Lbl1.Text = "Starting to get ready when the pitcher begins coming toward you in their delivery will give you the best chance of seeing the ball your best and making contact.";
            Lbl2.Text = "Press below to see the video.";
            mediaElement.IsVisible = false;
            SoftballVideo.IsVisible = true;
            SoftballVideo.IsVisible = true;
        }
    }

    void Navigate_Clicked(System.Object sender, System.EventArgs e)
    {

        Lbl2.IsVisible = true;
        Navigate.IsVisible = false;


    }

    void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new BreatheCorrectly()); } catch (Exception ex) { Console.Write(ex); }

    }



    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Cool!", "Glad that worked out for you. I can send you back to the homepage if you'd like!", "Ok", "Cancel");

        if (response)
        {
            await Navigation.PopToRootAsync();
        }
    }

    void mediaElement_MediaOpened(System.Object sender, System.EventArgs e)
    {
        Lbl2.IsVisible = true;
        Navigate.IsVisible = false;

    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        Lbl3.IsVisible = true;
        Yes.IsVisible = true;
        No.IsVisible = true;
        Lbl2.IsVisible = false;
    }

    async void SoftballVideo_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SoftballVideo()); } catch (Exception ex) { Console.Write(ex); }
    }
}