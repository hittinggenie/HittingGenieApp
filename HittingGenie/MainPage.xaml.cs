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
        await Navigation.PushAsync(new Pages.TeeOrToss());
    }

    async void GamesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.GamePractice = "Games";
        await Navigation.PushAsync(new Pages.OptionsPage());
    }
}


