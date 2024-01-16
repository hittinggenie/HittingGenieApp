namespace HittingGenie.Pages.Mechanics;

public partial class TurnBarrelVideo : ContentPage
{
	public TurnBarrelVideo()
	{
		InitializeComponent();
	}

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        Lbl2.IsVisible = true;
        Yes.IsVisible = true;
        No.IsVisible = true;
    }

    async void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SenseSwing()); } catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
