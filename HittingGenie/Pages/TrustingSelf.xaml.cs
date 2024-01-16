namespace HittingGenie.Pages;

public partial class TrustingSelf : ContentPage
{
	public TrustingSelf()
	{
		InitializeComponent();
	}

    async void Focused_Clicked(System.Object sender, System.EventArgs e)
    {

        try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }

    }

    async void NotFocused_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FurtherExplainVideo()); } catch (Exception ex) { Console.Write(ex); }

    }
}