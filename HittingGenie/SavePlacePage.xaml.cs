namespace HittingGenie;

public partial class SavePlacePage : ContentPage
{

    public SavePlacePage()
    {
        InitializeComponent();
    }



    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        string savedPlace = await SecureStorage.GetAsync("SavePlace");
        var mappings = PageMappings.GetMappings();

        Page nextPage = mappings[savedPlace]();
        try { await Navigation.PushAsync(new NavigationPage(nextPage)); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        SecureStorage.Remove("SavePlace");
        Func<Page> mainPageFunc;
        var mappings = PageMappings.GetMappings();
        if (mappings.TryGetValue("MainPage", out mainPageFunc))
        {
            Page mainPage = mainPageFunc.Invoke();

            try
            {
                await Navigation.PushAsync(new NavigationPage(mainPage));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        else
        {
            Console.WriteLine("MainPage not found in mappings.");
        }
    }
}
