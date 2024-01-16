namespace HittingGenie.Pages.Mechanics;

public partial class ConnectedGround : ContentPage
{
	public ConnectedGround()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "What Does This Mean?")
        {
            Navigator.Text = "Okay, That Makes Sense";
            Lbl2.IsVisible = true;
        }
        else if (Navigator.Text == "Okay, That Makes Sense")
        {
            Navigator.IsVisible = false;
            Lbl3.IsVisible = true;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
            NotSureBtn.IsVisible = true;
        }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Coiled()); } catch (Exception ex) { Console.Write(ex); }

    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Honesty()); } catch (Exception ex) { Console.Write(ex); }

    }


    async void NotSureBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Honesty()); } catch (Exception ex) { Console.Write(ex); }
    }
}