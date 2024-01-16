namespace HittingGenie.Pages.Mechanics;

public partial class Machine : ContentPage
{
	public Machine()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "Got It")
        {
            Lbl2.IsVisible = true;
            Navigator.Text = "Tight Rope. Got It.";
        }
        else if (Navigator.Text == "Tight Rope. Got It.")
        {
            Lbl3.IsVisible = true;
            Navigator.Text = "Okay";

        }
        else if (Navigator.Text == "Okay")
        {
            Navigator.IsVisible = false;
            Lbl4.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new StepStraight()); } catch (Exception ex) { Console.Write(ex); }

    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new MechanicsVideo()); } catch (Exception ex) { Console.Write(ex); }

    }
}