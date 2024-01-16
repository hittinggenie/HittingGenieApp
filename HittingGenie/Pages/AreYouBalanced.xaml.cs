namespace HittingGenie.Pages;

public partial class AreYouBalanced : ContentPage
{
	public AreYouBalanced()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new ReadyRelease2()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new LungingOrStuck()); } catch (Exception ex) { Console.Write(ex); }
    }
}
