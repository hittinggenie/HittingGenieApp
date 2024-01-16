namespace HittingGenie;

public partial class WhichSport : ContentPage
{
	public WhichSport()
	{
		InitializeComponent();
	}

    async void Baseball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Sport = "Baseball";
       try { await Navigation.PushAsync(new Pages.ReadyLoading()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void Softball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Sport = "Softball";
        try { await Navigation.PushAsync(new Pages.ReadyLoading()); } catch (Exception ex) { Console.Write(ex); }
    }
}
