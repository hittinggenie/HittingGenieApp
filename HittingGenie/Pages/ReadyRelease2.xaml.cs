namespace HittingGenie.Pages;

public partial class ReadyRelease2 : ContentPage
{
	public ReadyRelease2()
	{
		InitializeComponent();
	}

    async void ThisWorked_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    async void DidntWork_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new TrustingSelf()); } catch (Exception ex) { Console.Write(ex); }
    }
}
