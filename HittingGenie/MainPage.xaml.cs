namespace HittingGenie;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Settings.IsVisible = false;
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

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        Settings.IsVisible = !Settings.IsVisible;
    }

    async void EditProfile_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Profile.ProfileInfo()); } catch (Exception ex) { Console.Write(ex); }
    }

   async void Settings_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.Settings.Settings()); } catch (Exception ex) { Console.Write(ex); }
    }
}


