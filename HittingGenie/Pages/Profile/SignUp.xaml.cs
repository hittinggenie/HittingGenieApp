namespace HittingGenie.Pages.Profile;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();


    }

    async void Register_Clicked(System.Object sender, System.EventArgs e)
    {
        Constants.Name = userName.Text;
        Constants.Email = userEmail.Text;
        Constants.Phone = userPhone.Text;
        Constants.IsSignedIn = true;
        await Navigation.PopToRootAsync();
    }


   async void Login_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new Login()); } catch (Exception ex) { Console.Write(ex); }
    }
}
