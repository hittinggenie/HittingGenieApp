namespace HittingGenie.Pages.VRPHelp;

public partial class Attention : ContentPage
{
	public Attention()
	{
		InitializeComponent();
	}

   async void MultiUseBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (MultiUseBtn.Text != "Okay")
        {
            MultiUseBtn.Text = "Okay";
            VRPLbl.IsVisible = true;
        } else if (MultiUseBtn.Text == "Okay")
        {
            try
            {
                await Navigation.PushAsync(new VRP1());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        
        
    }
}

