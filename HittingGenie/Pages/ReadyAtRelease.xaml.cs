namespace HittingGenie.Pages;

public partial class ReadyAtRelease : ContentPage
{
	public ReadyAtRelease()
	{
		InitializeComponent();
	}

    async void Ok_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SendToMechanics()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void DoesntWork_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new TrustingSelf()); } catch (Exception ex) { Console.Write(ex); }
    }
}
