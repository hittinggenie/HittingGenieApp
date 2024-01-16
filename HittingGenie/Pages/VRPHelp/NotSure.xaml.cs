namespace HittingGenie.Pages.VRPHelp;

public partial class NotSure : ContentPage
{
	public NotSure()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NotSureVideo()); } catch (Exception ex) { Console.Write(ex); }

    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NotSureVideo()); } catch (Exception ex) { Console.Write(ex); }

    }
}