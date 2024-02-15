namespace HittingGenie.Pages.Mechanics;

public partial class Honesty : ContentPage
{
	public Honesty()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "How Else Can I Fix This?")
        {
            Navigator.Text = "Okay, I Will Try This";
            Lbl2.IsVisible = true;

        }
        else if (Navigator.Text == "Okay, I Will Try This")
        {
            Navigator.IsVisible = false;
            YesBtn.IsVisible = true;
            Save.IsVisible = true;
        }
    }

    async void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Coiled()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new FlareKnees()); } catch (Exception ex) { Console.Write(ex); }

    }
}