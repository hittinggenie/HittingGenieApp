using Firebase.Auth;

namespace HittingGenie.Pages.Mechanics;

public partial class StepStraight : ContentPage
{
	public StepStraight()
	{
		InitializeComponent();
	}

    async void Next_Clicked(System.Object sender, System.EventArgs e)
    {
        await SecureStorage.SetAsync("SavePlace", "Pages.Mechanics.FluidMotion()");
       
    }

    async void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }
}
