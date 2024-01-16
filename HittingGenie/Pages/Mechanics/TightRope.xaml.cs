using System.Reflection.PortableExecutable;

namespace HittingGenie.Pages.Mechanics;

public partial class TightRope : ContentPage
{
	public TightRope()
	{
		InitializeComponent();
	}

    void MultiStepBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (MultiStepBtn.Text == "Okay, Now What?")
        {
            Lbl2.IsVisible = true;
            MultiStepBtn.Text = "What Does This Do?";
        }
        else if (MultiStepBtn.Text == "What Does This Do?")
        {
            Lbl3.IsVisible = true;
            MultiStepBtn.Text = "Okay";
        }
        else if (MultiStepBtn.Text == "Okay")
        {
            Lbl4.IsVisible = true;
            MultiStepBtn.IsVisible = false;
            BaseballBtn.IsVisible = true;
            SoftballBtn.IsVisible = true;
        }
    }

    async void BaseballBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new BaseballRopeVideo()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void SoftballBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SoftballRopeVideo()); } catch (Exception ex) { Console.Write(ex); }
    }

   
}