namespace HittingGenie.Pages.Mechanics;

public partial class MoreReady : ContentPage
{
	public MoreReady()
	{
		InitializeComponent();
	}

    void FinalThoughts_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }


    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Remember!", "In order to grant your wish as best as possible, understand you may fail, " +
            "believe in your preparation and trust your eyes. Have a Visual Reference Point (VRP), " +
            "give 100% of your attention to the ball and go for it!", "Ok", "Go Back");

        if (response)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
