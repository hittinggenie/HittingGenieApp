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

        if (response) // TODO here we need to save progress
        {
            await Navigation.PopToRootAsync();
        }
    }

    async void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new VRPGuide());  } catch (Exception ex) { Console.Write(ex); }

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
        mediaElement.Handler?.DisconnectHandler();
    }

    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = false;
        NoBtn.IsVisible = false;
        mediaElement.IsVisible = true;
        Lbl2.IsVisible = false;
        Lbl3.Text = "Please tap the video in the box below to start the video.";
    }

     void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

  
}
