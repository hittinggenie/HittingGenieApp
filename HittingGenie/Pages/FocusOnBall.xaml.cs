

namespace HittingGenie.Pages;
public partial class FocusOnBall : ContentPage
{
    public FocusOnBall()
    {
        InitializeComponent();
        if (Constants.OptionType == "Approach" || Constants.OptionType == "Mechanics" || Constants.OptionType == "Timing")
        {
            Lbl1.Text = "Great, let's work together.";
        }
        else if (Constants.OptionType == "NotSure")
        {
            Lbl1.Text = "It's okay not to know, let's work together.";
        }
    }

    async void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Constants.Baseball == true)
        {
          //  try { await Navigation.PushAsync(new YesRoute.PitchersKnee("baseball")); } catch (Exception ex) { Console.Write(ex); }


        }
        else if (Constants.Softball == true)
        {
           // try { await Navigation.PushAsync(new YesRoute.PitchersKnee("softball")); } catch (Exception ex) { Console.Write(ex); }
        }

    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
       // try { await Navigation.PushAsync(new NoRoute.AttentionIntention()); } catch (Exception ex) { Console.Write(ex); }

    }
}
