﻿using CommunityToolkit.Maui.Views;
using Firebase.Auth;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
namespace HittingGenie.Pages;

public partial class BaseSoftTimingVideo : ContentPage
{
    public BaseSoftTimingVideo()
    {
        InitializeComponent();
        if (Constants.Sport == "Baseball")
        {
            Lbl1.Text = "Starting to get ready when the pitcher's lead knee hits its highest point will give you the best chance of seeing the ball your best and making contact. Do this and let me know how it goes. Don't forget to save your progress in case you have another question about this!";
            videoPlayer.Source = "https://www.youtube.com/embed/TFUGZSElLBA?rel=0";



        }
        else if (Constants.Sport == "Softball")
        {
            Lbl1.Text = "Starting to get ready when the pitcher begins coming toward you in their delivery will give you the best chance of seeing the ball your best and making contact.";
            videoPlayer.Source = "https://www.youtube.com/embed/9FHp5x1HsOk?rel=0";


        }
    }


    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        double newWidth = width - 50;

        videoPlayer.WidthRequest = newWidth;
    }

    void Navigate_Clicked(System.Object sender, System.EventArgs e)
    {

        Lbl2.IsVisible = true;
        videoPlayer.IsVisible = true;
        Navigate.IsVisible = false;
        VideoWatched.IsVisible = true;


    }

    void Yes_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowPopupMessage();
    }

    async void No_Clicked(System.Object sender, System.EventArgs e)
    {
        try { await Navigation.PushAsync(new BreatheCorrectly()); } catch (Exception ex) { Console.Write(ex); }

    }



    private async void ShowPopupMessage()
    {
        bool response = await DisplayAlert("Cool!", "Glad that worked out for you. I can send you back to the homepage if you'd like!", "Ok", "Cancel");

        if (response)
        {
            await Navigation.PopToRootAsync();
        }
    }

  

    void ContentPage_Unloaded(System.Object sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        videoPlayer.Handler?.DisconnectHandler();
    }



    void VideoWatched_Clicked(System.Object sender, System.EventArgs e)
    {
        Lbl1.IsVisible = false;
        Lbl3.IsVisible = true;
        Yes.IsVisible = true;
        No.IsVisible = true;
        Lbl2.IsVisible = false;
        VideoWatched.IsVisible = false;
    }

   async void SaveBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await SecureStorage.SetAsync("SavePlace", "Pages.BaseSoftTimingVideo()");
    }
}