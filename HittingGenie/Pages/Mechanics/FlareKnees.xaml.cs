namespace HittingGenie.Pages.Mechanics;

public partial class FlareKnees : ContentPage
{
	public FlareKnees()
	{
		InitializeComponent();
	}

    async void NextStep_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Coiled()); } catch (Exception ex) { Console.Write(ex); }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }
}
