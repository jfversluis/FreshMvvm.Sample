using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm.Sample.PageModels;
using FreshMvvm.Sample.Pages;
using Xamarin.Forms;

namespace FreshMvvm.Sample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var mainPage = new FreshTabbedNavigationContainer();

            mainPage.AddTab<TabOnePageModel>("Hello", null);
            mainPage.AddTab<TabTwoPageModel>("unicorn!", null);
            MainPage = mainPage;
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
