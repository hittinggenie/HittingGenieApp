namespace HittingGenie.Pages.VRPHelp;

public partial class EarlyOrLate : ContentPage
{
	public EarlyOrLate()
	{
		InitializeComponent();
        ChangeTextTags("Default");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ChangeTextTags("Default");
    }

    void TooEarly_Clicked(System.Object sender, System.EventArgs e)
    {
        ChangeTextTags("TooEarly");
    }

    void TooLate_Clicked(System.Object sender, System.EventArgs e)
    {

        ChangeTextTags("TooLate");
    }

    void OnTime_Clicked(System.Object sender, System.EventArgs e)
    {
        ChangeTextTags("OnTime");
    }

    private async void ChangeTextTags(string buttonName)
    {
        if (buttonName == "TooEarly")
        {
            Lbl1.Text = "Move your VRP more to the opposite field. This will help your timing to hit the ball harder somewhere.";

            HideButtonsShowIndicator();


        }
        else if (buttonName == "TooLate")
        {
            Lbl1.Text = "Move your VRP more to the pull side of the field. This will help your timing to hit the ball harder somewhere.";
            HideButtonsShowIndicator();

        }
        else if (buttonName == "OnTime")
        {
            try
            {
                await Navigation.PushAsync(new VideoOption());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }
        else if (buttonName == "Default")
        {
            Lbl1.Text = "Did you feel you were too early, too late, or on time?";
            NotSure.IsVisible = false;
            ShowButtons();
        }
    }


    void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SlowPitcher());
        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

    }
    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Nice!", "Saving your answers and sending you back to the homepage.", "Ok", "Cancel");

        if (response)
        {
            await Navigation.PopToRootAsync();
        }
    }

    void ShowButtons()
    {
        TooEarly.IsVisible = true;
        TooLate.IsVisible = true;
        OnTime.IsVisible = true;
        NotSure.IsVisible = true;
        Yes.IsVisible = false;
        No.IsVisible = false;
    }

    async void HideButtonsShowIndicator()
    {
        TooEarly.IsVisible = false;
        TooLate.IsVisible = false;
        OnTime.IsVisible = false;
        NotSure.IsVisible = false;
        activityIndicator.IsRunning = true;
        activityIndicator.IsVisible = true;
        await Task.Delay(3000);
        Yes.IsVisible = true;
        No.IsVisible = true;
        activityIndicator.IsRunning = false;
        activityIndicator.IsVisible = false;
        Lbl2.IsVisible = true;

    }

    async void NotSure_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new NotSure());
        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

    }
}
