namespace HittingGenie.Pages;

public partial class OptionsPage : ContentPage
{
	public OptionsPage()
	{
		InitializeComponent();
	}

    async void MentalApproach_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "Approach";
        await Navigation.PushAsync(new FocusOnBall());
    }

    async void Mechanics_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "Mechanics";
        await Navigation.PushAsync(new FocusOnBall());
    }

    async void NotSure_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "NotSure";
        await Navigation.PushAsync(new FocusOnBall());
    }


    async void Timing_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "Timing";
        await Navigation.PushAsync(new FocusOnBall());
    }
}
