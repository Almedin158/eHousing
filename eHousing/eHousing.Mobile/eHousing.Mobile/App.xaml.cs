using eHousing.Mobile.Views;
using eHousing.Mobile.Views.Account;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHousing.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDYxNTIwQDMxMzkyZTMxMmUzMExiMkl3T0JSOXZsdW43c0lRNDZwNlBGdzk4U0MvWUloMjY0STUwSjRsRVU9");
            MainPage = new LoginPage();
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
