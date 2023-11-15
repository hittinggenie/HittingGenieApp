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

        if (Constants.GamePractice == "Games")
        {
            await Navigation.PushAsync(new FocusOnBall());
        }
        else if (Constants.GamePractice == "Practice") 
        {
            try { await Navigation.PushAsync(new VideoPages.PracticeVideo()); } catch (Exception ex) { Console.Write(ex); }
        }
       
    }

    async void Mechanics_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "Mechanics";
        if (Constants.GamePractice == "Games")
        {
            await Navigation.PushAsync(new FocusOnBall());
        }
        else if (Constants.GamePractice == "Practice")
        {
            try { await Navigation.PushAsync(new VideoPages.PracticeVideo()); } catch (Exception ex) { Console.Write(ex); }
        }

    }

    async void NotSure_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "NotSure";
        if (Constants.GamePractice == "Games")
        {
            await Navigation.PushAsync(new FocusOnBall());
        }
        else if (Constants.GamePractice == "Practice")
        {
            try { await Navigation.PushAsync(new VideoPages.PracticeVideo()); } catch (Exception ex) { Console.Write(ex); }
        }

    }


    async void Timing_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.OptionType = "Timing";
        if (Constants.GamePractice == "Games")
        {
            await Navigation.PushAsync(new FocusOnBall());
        }
        else if (Constants.GamePractice == "Practice")
        {
            try { await Navigation.PushAsync(new VideoPages.PracticeVideo()); } catch (Exception ex) { Console.Write(ex); }
        }

    }
}
