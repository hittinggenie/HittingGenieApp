namespace HittingGenie.Pages.Mechanics;

public partial class MakeSlower : ContentPage
{
	public MakeSlower()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new TurnBarrelVideo()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "How?")
        {
            Lbl2.IsVisible = true;
            Navigator.Text = "Tell Me More!";
        }
        else if (Navigator.Text == "Tell Me More!")
        {
            Lbl3.IsVisible = true;
            Navigator.IsVisible = false;
            logo.IsVisible = false;
            Lbl3.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }
}
