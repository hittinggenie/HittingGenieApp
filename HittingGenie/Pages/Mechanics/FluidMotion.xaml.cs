namespace HittingGenie.Pages.Mechanics;

public partial class FluidMotion : ContentPage
{
	public FluidMotion()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new DroppingHands()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NotSure_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new CommonBelief());
        }
        catch (Exception ex) { Console.Write(ex); }
    }
}
