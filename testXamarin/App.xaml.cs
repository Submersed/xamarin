using testXamarin.Data;
using testXamarin.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            DBHelper.ResetDB();
            MainPage = new NavigationPage(new Login());
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
