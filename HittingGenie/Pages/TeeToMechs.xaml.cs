namespace HittingGenie.Pages;

public partial class TeeToMechs : ContentPage
{
	public TeeToMechs()
	{
		InitializeComponent();
	}

   async void GoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
         try { await Navigation.PushAsync(new Mechanics.MechHome()); } catch (Exception ex) { Console.Write(ex); }
    }
}
