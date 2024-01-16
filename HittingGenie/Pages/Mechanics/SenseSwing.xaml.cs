namespace HittingGenie.Pages.Mechanics;

public partial class SenseSwing : ContentPage
{
	public SenseSwing()
	{
		InitializeComponent();
	}

    async void NotStraight_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FrontFootLandingVideo()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void AmStraight_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FrontFootLandingVideo()); }  catch (Exception ex) { Console.Write(ex); }
    }
}
