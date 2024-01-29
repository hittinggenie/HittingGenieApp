namespace HittingGenie.Pages.Profile;

public partial class ProfileInfo : ContentPage
{
	public ProfileInfo()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Name.Text = Constants.Name + "'s Hitting Genie Profile"; //TODO: make it so that it is whatever this person's name is
        userName.Text = Constants.Name;
        userEmail.Text = Constants.Email;
    }
}
