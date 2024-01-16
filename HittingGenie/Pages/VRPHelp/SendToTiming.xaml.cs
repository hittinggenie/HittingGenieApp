namespace HittingGenie.Pages.VRPHelp;

public partial class SendToTiming : ContentPage
{
	public SendToTiming()
	{
		InitializeComponent();
	}

    async void FixTimingBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		try { await Navigation.PushAsync(new WhichSport()); } catch (Exception ex) { Console.Write(ex); }
    } 
}
