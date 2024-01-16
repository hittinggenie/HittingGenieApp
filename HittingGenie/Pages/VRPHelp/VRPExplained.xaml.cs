using System.Diagnostics.Metrics;

namespace HittingGenie.Pages.VRPHelp;

public partial class VRPExplained : ContentPage
{
    private int counter = 0;
    public VRPExplained()
    {
        InitializeComponent();
        MultiUseBtn.Text = "I Would Like That";

    }

    async void MultiUseBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (MultiUseBtn.Text == "Yes, Please!")
        {
            try { await Navigation.PushAsync(new VRPGuide()); } catch (Exception ex) { Console.Write(ex); }

        }
        else
        {
            counter += 1;
            DoTextLogic();

        }
    }

    private void DoTextLogic()
    {
        switch (counter)
        {

            case 1:
                Lbl2.IsVisible = true;
                MultiUseBtn.Text = "Next";
                break;
            case 2:
                Lbl3.IsVisible = true;
                MultiUseBtn.Text = "Explain What That Means";
                break;
            case 3:
                Lbl4.IsVisible = true;
                MultiUseBtn.Text = "Yes, Please!";
                NoBtn.IsVisible = true;
                NoBtn.Text = "No Thanks";
                break;

        }
    }

    private void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Thank you for your response!", "Saving your progress and sending you back to the homepage.", "Ok", "Cancel");

        if (response)
        {
            await Navigation.PopToRootAsync();
        }
    }


}