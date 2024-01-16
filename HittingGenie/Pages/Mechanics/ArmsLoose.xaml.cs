﻿namespace HittingGenie.Pages.Mechanics;

public partial class ArmsLoose : ContentPage
{
	public ArmsLoose()
	{
		InitializeComponent();
	}

    async void YesBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new StartLoading()); } catch (Exception ex) { Console.Write(ex); }
    }

    async void NoBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new SwingQuicknessVideo()); } catch (Exception ex) { Console.Write(ex); }
    }
}
