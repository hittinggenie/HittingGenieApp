namespace HittingGenie.Pages.Mechanics;

public partial class MakeContact : ContentPage
{
	public MakeContact()
	{
		InitializeComponent();
	}

    async void PullSide_Clicked(System.Object sender, System.EventArgs e)
    {
      try { await Navigation.PushAsync(new MechEarlyLate()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void OppoField_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new MechEarlyLate()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NotMuch_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new MechEarlyLate()); } catch (Exception ex) { Console.Write(ex); }
    }
}
