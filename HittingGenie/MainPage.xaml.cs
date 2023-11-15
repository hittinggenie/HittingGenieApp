namespace HittingGenie;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void PracticeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    async void GamesBtn_Clicked(System.Object sender, System.EventArgs e)
    { 

        await Navigation.PushAsync(new Pages.OptionsPage());
    }
}


