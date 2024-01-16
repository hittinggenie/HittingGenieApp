namespace HittingGenie.Pages.Mechanics;

public partial class Rhythm : ContentPage
{
	public Rhythm()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "What Do You Mean?")
        {
            Lbl2.IsVisible = true;
            Navigator.Text = "Okay, I Will Remember That";
        } else if (Navigator.Text == "Okay, I Will Remember That")
        {
            Lbl3.IsVisible = true;
            Navigator.IsVisible = false;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }
    }

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new OneMove()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new OneMove()); } catch (Exception ex) { Console.Write(ex); }
    }
}
