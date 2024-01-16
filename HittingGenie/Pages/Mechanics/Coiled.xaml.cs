namespace HittingGenie.Pages.Mechanics;

public partial class Coiled : ContentPage
{
	public Coiled()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "How Does This Help?")
        {
            Lbl2.IsVisible = true;
            Navigator.Text = "I Understand";
        }
        else if (Navigator.Text == "I Understand")
        {
            Navigator.IsVisible = false;
            Lbl3.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new StartingPosition());
        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SetHips());
        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

    }
}
