namespace HittingGenie;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);
        logo.FadeTo(1, 10000);
        

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

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Settings.Settings()); } catch (Exception ex) { Console.Write(ex); }
    }

   
}


