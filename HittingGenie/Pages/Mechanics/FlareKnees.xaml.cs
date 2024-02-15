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
}
