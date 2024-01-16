namespace HittingGenie.Pages.Mechanics;

public partial class MechHome : ContentPage
{
	public MechHome()
	{
		InitializeComponent();
	}

    async void Next_Clicked(System.Object sender, System.EventArgs e)
    { 
		try { await Navigation.PushAsync(new ConnectedGround()); } catch (Exception ex) { Console.Write(ex); }
    }
}
