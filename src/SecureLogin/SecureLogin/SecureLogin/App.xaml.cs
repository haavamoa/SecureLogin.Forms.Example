using System;
using System.Linq;
using SecureLogin.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            //MainPage is NavigationPage
            var navigationPage = (NavigationPage)App.Current.MainPage;
            ((SafePageBase)App.Current.MainPage.Navigation.NavigationStack.Last()).OnSleep();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
