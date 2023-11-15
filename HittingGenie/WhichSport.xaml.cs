namespace HittingGenie;

public partial class WhichSport : ContentPage
{
	public WhichSport()
	{
		InitializeComponent();
	}

    void Baseball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Baseball = true;
        Constants.Softball = false;
    }

    void Softball_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Baseball = false;
        Constants.Softball = true;
    }
}
