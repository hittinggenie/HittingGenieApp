namespace HittingGenie.Pages.Mechanics;

public partial class StartingPosition : ContentPage
{
	public StartingPosition()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "Hooray!")
        {
            Navigator.Text = "Let's See...";
            Lbl2.IsVisible = true;
        }
        else if (Navigator.Text == "Let's See...")
        {
            Navigator.IsVisible = false;
            Lbl3.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {

        try { await Navigation.PushAsync(new ArmsLoose()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new NoStartingPosition()); } catch (Exception ex) { Console.Write(ex); }

    }
}