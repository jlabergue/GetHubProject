using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GetHubProject
{
    public class App : Application
    {
        public App()
        {
            IntializeComponent();
            MainPage = new ContentPage()
            {
                Content = new Label
                {

                    Text = "Welcome to Xamarin Forms!",
                    TextColor = Color.Red
                },
                BackgroundColor = Color.Purple
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
