namespace HittingGenie.Pages.Mechanics;

public partial class OneMove : ContentPage
{
	public OneMove()
	{
		InitializeComponent();
	}

    void Navigator_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Navigator.Text == "How Can I Correct This?")
        {
            Lbl2.IsVisible = true;
            Navigator.Text = "Okay, I Will Try That";
        }
        else if (Navigator.Text == "Okay, I Will Try That")
        {
            Lbl3.IsVisible = true;
            Navigator.IsVisible = false;
            YesBtn.IsVisible = true;
            NoBtn.IsVisible = true;
        }


    }

    void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {

        try { await Navigation.PushAsync(new TightRope()); } catch (Exception ex) { Console.Write(ex); }
    }

    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Great!", "Saving your progress in case we need to chat about this again.", "Ok", "Cancel");

        if (response)
        {
           try { await Navigation.PushAsync(new TightRope()); } catch (Exception ex) { Console.Write(ex); }
        }
    }
}