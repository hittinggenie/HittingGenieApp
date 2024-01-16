namespace HittingGenie.Pages.Mechanics;

public partial class NoStartingPosition : ContentPage
{
	public NoStartingPosition()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new ArmsLoose()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void SaveBtn_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new ArmsLoose()); } catch (Exception ex) { Console.Write(ex); }
    }

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        Lbl2.IsVisible = true;
        YesBtn.IsVisible = true;
        SaveBtn.IsVisible = true;
        Navigator.IsVisible = false;
    }
}
