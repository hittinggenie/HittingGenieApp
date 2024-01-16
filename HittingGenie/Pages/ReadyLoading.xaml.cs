namespace HittingGenie.Pages;

public partial class ReadyLoading : ContentPage
{
	public ReadyLoading()
	{
		InitializeComponent();
		if (Constants.Sport == "Baseball")
		{
			Lbl1.Text = "Do you begin getting ready \"loading\" when the pitcher's knee reaches it's highest point?";

        } else if (Constants.Sport == "Softball")
		{
			Lbl1.Text = "Do you begin getting ready \"loading\" the moment the pitcher begins to come towards you in their delivery?";

        }
	}

    async void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new BreatheCorrectly()); } catch (Exception ex) { Console.Write(ex); }

    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new BaseSoftTimingVideo()); } catch (Exception ex) { Console.Write(ex); }

    }
}
