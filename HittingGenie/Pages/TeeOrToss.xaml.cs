namespace HittingGenie.Pages;

public partial class TeeOrToss : ContentPage
{
	public TeeOrToss()
	{
		InitializeComponent();
	}

    async void Tee_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new TeeToMechs());
    }

    async void FrontToss_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new OptionsPage());
    }

    async void Overhand_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new OptionsPage());
    }

    async void LiveBaseball_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new OptionsPage());
    }

    async void LiveSoftball_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new OptionsPage());
    }
}
