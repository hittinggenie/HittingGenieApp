namespace HittingGenie.Pages;

public partial class SendToMechanics : ContentPage
{
	public SendToMechanics()
	{
		InitializeComponent();
	}

    async void MechanicsBtn_Clicked(System.Object sender, System.EventArgs e)
    {
           try { await Navigation.PushAsync(new Mechanics.MechHome()); } catch (Exception ex) { Console.Write(ex); }
    }
}
