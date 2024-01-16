

namespace HittingGenie.Pages;

public partial class FurtherExplainVideo : ContentPage
{
	public FurtherExplainVideo()
	{
		InitializeComponent();
	}

    void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();

    }

    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {

        mediaElement.IsVisible = true;
        YesBtn.IsVisible = false;
        NoBtn.IsVisible = false;
        Lbl3.Text = "Please watch this video below to proceed.";

    }
    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }


    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Thank you for your response!", "Saving your progress and sending you to a new page.", "Ok", "Cancel");

        if (response)
        {
            try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }
        }
    }

    async void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }
    }
}