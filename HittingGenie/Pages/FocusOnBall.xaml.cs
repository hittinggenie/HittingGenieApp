

namespace HittingGenie.Pages;
public partial class FocusOnBall : ContentPage
{
    public FocusOnBall()
    {
        InitializeComponent();
        if (Constants.OptionType == "Approach"  || Constants.OptionType == "Mechanics" || Constants.OptionType == "Timing")
        {
            Lbl1.Text = "Great, let's work together.";
            Lbl1.TextColor = Color.FromArgb("#000000");
        }
        else if (Constants.OptionType == "NotSure")
        {
            Lbl1.Text = "It's okay. That's why you summoned me. Answer these questions and I'll grant your wish.";
        }
    }

    async void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Constants.Sport != "Baseball" || Constants.Sport != "Softball")
        {
          
            try { await Navigation.PushAsync(new WhichSport()); } catch (Exception ex) { Console.Write(ex); }

        }
        else 
        {
            try { await Navigation.PushAsync(new ReadyLoading()); } catch (Exception ex) { Console.Write(ex); }
        }

    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new VRPHelp.Attention()); } catch (Exception ex) { Console.Write(ex); }

    }
}
