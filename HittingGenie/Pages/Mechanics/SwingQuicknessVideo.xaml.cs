namespace HittingGenie.Pages.Mechanics;

public partial class SwingQuicknessVideo : ContentPage
{
	public SwingQuicknessVideo()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NoHesitation()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new UseWrists());  } catch (Exception ex) { Console.Write(ex); }
    }

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = true;
        NoBtn.IsVisible = true;
        Lbl3.IsVisible = true;
        Lbl1.IsVisible = false;
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
