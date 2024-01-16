namespace HittingGenie.Pages;

public partial class LungingOrStuck : ContentPage
{
	public LungingOrStuck()
	{
		InitializeComponent();
	}

    async void Forward_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new ReadyAtRelease()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void Stuck_Clicked(System.Object sender, System.EventArgs e)
    {
       try { await Navigation.PushAsync(new ReadyAtRelease()); } catch (Exception ex) { Console.Write(ex); }
    }
}
