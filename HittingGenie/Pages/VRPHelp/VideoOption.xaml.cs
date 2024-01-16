namespace HittingGenie.Pages.VRPHelp;

public partial class VideoOption : ContentPage
{
	public VideoOption()
	{
		InitializeComponent();
		if (Constants.GamePractice == "Practice")
		{
			TimingOrMechs.Text = "Please Help Fix My Mechanics;";
			Lbl2.IsVisible = false;
			MechsBtn.IsVisible = false;

		} else if (Constants.GamePractice == "Games")
		{
			Lbl2.IsVisible = true;
			MechsBtn.IsVisible = true;
		}
	}

    async void TimingOrMechs_Clicked(System.Object sender, System.EventArgs e)
    {
		if (Constants.GamePractice == "Practice")
		{
            try { await Navigation.PushAsync(new Mechanics.MechHome()); } catch (Exception ex) { Console.Write(ex); }
        } else
		{
            try { await Navigation.PushAsync(new WhichSport()); } catch (Exception ex) { Console.Write(ex); }
        }

		
    }

    async void MechsBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Mechanics.MechHome());
        }
        catch (Exception ex) { Console.Write(ex); }
    }
}