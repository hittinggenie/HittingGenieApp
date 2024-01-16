namespace HittingGenie.Pages.Mechanics;

public partial class CommonBelief : ContentPage
{
	public CommonBelief()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Lbl1.IsVisible)
        {
            Lbl1.IsVisible = false;
            Lbl2.IsVisible = false;
            Lbl3.IsVisible = true;
        } else if (Lbl3.IsVisible)
        {
            try { await Navigation.PushAsync(new MakeSlower()); } catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Lbl1.IsVisible)
        {
            Lbl1.IsVisible = false;
            Lbl2.IsVisible = false;
            Lbl3.IsVisible = true;
        } else if (Lbl3.IsVisible) {
            try { await Navigation.PushAsync(new MakeSlower()); } catch (Exception ex) { Console.Write(ex); }
        }

    }
}
