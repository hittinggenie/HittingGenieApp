namespace HittingGenie.Pages;

public partial class BreatheCorrectly : ContentPage
{
	public BreatheCorrectly()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Constants.GamePractice == "Practice")
        {
            try { await Navigation.PushAsync(new VRPHelp.Attention()); } catch (Exception ex) { Console.Write(ex); }
        }
        else
        {
            try
            {
                await Navigation.PushAsync(new AreYouBalanced());
            }
            catch (Exception ex) { Console.Write(ex); }
        }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Constants.GamePractice == "Practice")
        {
            try { await Navigation.PushAsync(new VRPHelp.Attention()); } catch (Exception ex) { Console.Write(ex); }
        }
        else
        {
            try { await Navigation.PushAsync(new BreatheVideo()); } catch (Exception ex) { Console.Write(ex); }
        }
    }
}
