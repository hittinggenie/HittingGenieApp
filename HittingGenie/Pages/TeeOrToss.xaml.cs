namespace HittingGenie.Pages;

public partial class TeeOrToss : ContentPage
{
	public TeeOrToss()
	{
		InitializeComponent();
	}

    async void Tee_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.PracticeOption = "Tee";
       try { await Navigation.PushAsync(new TeeToMechs()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void FrontToss_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.PracticeOption = "Toss";
       try { await Navigation.PushAsync(new OptionsPage()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void Overhand_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.PracticeOption = "BP";
       try { await Navigation.PushAsync(new OptionsPage()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void LiveBaseball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Sport = "Baseball";
        Constants.GamePractice = "Games";
      try {  await Navigation.PushAsync(new OptionsPage()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void LiveSoftball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Sport = "Softball";
        Constants.GamePractice = "Games";
       try { await Navigation.PushAsync(new OptionsPage()); } catch (Exception ex) { Console.Write(ex); }
    }
}
