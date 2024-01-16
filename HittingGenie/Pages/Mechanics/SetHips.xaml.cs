namespace HittingGenie.Pages.Mechanics;

public partial class SetHips : ContentPage
{
	public SetHips()
	{
		InitializeComponent();
	}

    async void NextBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		try { await Navigation.PushAsync(new StartingPosition()); } catch (Exception ex) { Console.Write(ex); }
    }
}
