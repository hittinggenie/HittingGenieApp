namespace HittingGenie.Pages.VRPHelp;

public partial class VRPGuide : ContentPage
{
	public VRPGuide()
	{
		InitializeComponent();
	}

    async void ItWorked_Clicked(System.Object sender, System.EventArgs e)
    {

        try { await Navigation.PushAsync(new EarlyOrLate()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void DidntWork_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new EarlyOrLate()); } catch (Exception ex) { Console.Write(ex); }
    }


}
