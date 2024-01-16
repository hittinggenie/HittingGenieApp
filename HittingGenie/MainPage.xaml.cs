namespace HittingGenie;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    async void PracticeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.GamePractice = "Practice";
       try { await Navigation.PushAsync(new Pages.TeeOrToss()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void GamesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.GamePractice = "Games";
       try { await Navigation.PushAsync(new Pages.OptionsPage()); } catch (Exception ex) { Console.Write(ex); }
    }
}


