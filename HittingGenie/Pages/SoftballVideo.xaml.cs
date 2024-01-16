namespace HittingGenie.Pages;

public partial class SoftballVideo : ContentPage
{
	public SoftballVideo()
	{
		InitializeComponent();
	}

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
		Yes.IsVisible = true;
		No.IsVisible = true;
		Lbl3.IsVisible = true;
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

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
