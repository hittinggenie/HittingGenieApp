namespace HittingGenie.Pages.VRPHelp;

public partial class NotSureVideo : ContentPage
{
    public NotSureVideo()
    {
        InitializeComponent();
    }

    void ShowMe_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();

    }


    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Awesome!", "Please select 'Ok' to save your progress. Go take a few swings and come back, and we will pick up from there!", "Ok", "Cancel");

        if (response)
        {
            try { await Navigation.PushAsync(new EarlyOrLate()); } catch (Exception ex) { Console.Write(ex); }

        }
    }

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        ShowMe.IsVisible = true;


        void ContentPage_Unloaded(System.Object sender, EventArgs e)
        {
            // Stop and cleanup MediaElement when we navigate away
            mediaElement.Handler?.DisconnectHandler();
        }
    }
}

