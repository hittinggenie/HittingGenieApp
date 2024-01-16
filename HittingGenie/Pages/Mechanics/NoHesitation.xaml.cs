namespace HittingGenie.Pages.Mechanics;

public partial class NoHesitation : ContentPage
{
	public NoHesitation()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new TightRope()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Rhythm()); } catch (Exception ex) { Console.Write(ex); }
    }
}
