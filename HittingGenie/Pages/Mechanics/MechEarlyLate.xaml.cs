namespace HittingGenie.Pages.Mechanics;

public partial class MechEarlyLate : ContentPage
{
	public MechEarlyLate()
	{
		InitializeComponent();
	}

    async void Early_Clicked(System.Object sender, System.EventArgs e)
    {
      try {  await Navigation.PushAsync(new Rhythm()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void Late_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new Rhythm()); } catch (Exception ex) { Console.Write(ex); }
    }

   async void OnTime_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new Rhythm()); } catch (Exception ex) { Console.Write(ex); }
    }
}
