namespace HittingGenie.Pages.Mechanics;

public partial class MechanicsVideo : ContentPage
{
	public MechanicsVideo()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new FluidMotion()); } catch (Exception ex) { Console.Write(ex); }
    }
}
