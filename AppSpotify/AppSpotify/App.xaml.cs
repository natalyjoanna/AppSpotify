﻿using AppSpotify.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSpotify
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListSongsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
