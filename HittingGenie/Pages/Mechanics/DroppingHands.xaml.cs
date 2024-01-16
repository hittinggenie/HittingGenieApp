namespace HittingGenie.Pages.Mechanics;

public partial class DroppingHands : ContentPage
{
	public DroppingHands()
	{
		InitializeComponent();
	}

    void Stepper_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Stepper.Text == "Yes, is This True?")
        {
            Lbl2.IsVisible = true;
            Stepper.Text = "Why Does That Matter?";
        } else if (Stepper.Text == "Why Does That Matter?")
        {
            Lbl3.IsVisible = true;
            Stepper.Text = "How Can I Fix It?";
        } else if (Stepper.Text == "How Can I Fix It?")
        {
            Lbl4.IsVisible = true;
            Stepper.IsVisible = false;
            HelpMe.IsVisible = true;
        }
    }

    async void HelpMe_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new CommonBelief()); } catch (Exception ex) { Console.Write(ex); }
    }
}
