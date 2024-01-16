namespace HittingGenie.Pages.Mechanics;

public partial class UseWrists : ContentPage
{
	public UseWrists()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NoHesitation()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NoHesitation()); } catch (Exception ex) { Console.Write(ex); }
    }
}
