

namespace HittingGenie.Pages.Mechanics;

public partial class SoftballRopeVideo : ContentPage
{
	public SoftballRopeVideo()
	{
		InitializeComponent();
	}

    void mediaElement_MediaEnded(System.Object sender, System.EventArgs e)
    {
        YesBtn.IsVisible = true;
        Lbl2.IsVisible = true;
        NoBtn.IsVisible = true;
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }

   async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Machine()); } catch (Exception ex) { Console.Write(ex); }
    }

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}
