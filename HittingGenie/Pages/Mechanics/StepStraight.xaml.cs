namespace HittingGenie.Pages.Mechanics;

public partial class StepStraight : ContentPage
{
	public StepStraight()
	{
		InitializeComponent();
	}

    async void Next_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }
}
