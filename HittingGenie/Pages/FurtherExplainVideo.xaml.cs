

namespace HittingGenie.Pages;

public partial class FurtherExplainVideo : ContentPage
{
    public FurtherExplainVideo()
    {
        InitializeComponent();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }

    void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();

    }


    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {

        videoPlayer.IsVisible = true;
        YesBtn.IsVisible = false;
        NoBtn.IsVisible = false;
        Lbl1.IsVisible = false;
        Lbl2.IsVisible = false;
        Lbl3.Text = "Please watch this video below to proceed, when you are finished press the Next Step button.";
        NextStep.IsVisible = true;
    }
    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        videoPlayer.Handler?.DisconnectHandler();
    }


    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Thank you for your response!", "Saving your progress and sending you to a new page.", "Ok", "Cancel");

        if (response)
        {
            try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }
        }
    }

    async void NextStep_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }
    }
}