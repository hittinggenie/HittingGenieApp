namespace HittingGenie.VideoPages;

public partial class PracticeVideo : ContentPage
{
	public PracticeVideo()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Constants.GamePractice == "Practice" && Constants.PracticeOption == "BP")
        {
            Lbl1.Text = "You must give yourself enough time to swing at each pitch. Here is how.";
            Lbl2.IsVisible = false;
            Lbl3.IsVisible = false;
            videoPlayer.Source = "https://www.youtube.com/embed/OkYXfO9LinI?rel=0";
        } else if (Constants.GamePractice == "Practice" && Constants.PracticeOption == "Toss")
        {
            videoPlayer.Source = "https://www.youtube.com/embed/lAY2OQ5Den0?rel=0";
            Lbl1.Text = "You must begin getting ready when the person throwing the ball to you moves.";
            Lbl2.IsVisible = true;
            Lbl3.IsVisible = true;
        }
    }


    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }

   async void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Pages.BreatheCorrectly()); } catch (Exception ex) { Console.Write(ex); }
    }
}
