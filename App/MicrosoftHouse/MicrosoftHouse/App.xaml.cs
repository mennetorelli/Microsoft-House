﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicrosoftHouse.Abstractions;
using MicrosoftHouse.Helpers;
using MicrosoftHouse.Services;
using Xamarin.Forms;

namespace MicrosoftHouse
{
    public partial class App : Application
    {
		public static ICloudService CloudService { get; set; }


        public App(string loadParameter = null)
        {
            ServiceLocator.Add<ICloudService, AzureCloudService>();

            MainPage = new NavigationPage(new EntryPage())
            {
                BarBackgroundColor = Color.FromHex("#2196F3")
            };

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
