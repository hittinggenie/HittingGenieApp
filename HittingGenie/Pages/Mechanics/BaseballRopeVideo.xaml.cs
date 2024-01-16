namespace HittingGenie.Pages.Mechanics;

public partial class BaseballRopeVideo : ContentPage
{
	public BaseballRopeVideo()
	{
		InitializeComponent();
	}

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = true;
        Lbl2.IsVisible = true;
        NoBtn.IsVisible = true;

    }
    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
        
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Machine()); } catch (Exception ex) { Console.Write(ex); }
    }

    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Great!", "Just remember, there is no stop in the swing. It's one fluid motion. Let's save your progress in case you'd like to chat again.", "Save", "Cancel");

        if (response)
        {
            try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
        }
    }
}
