using eHousing.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHousing.Mobile.Views.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            SignedInUser.User = null;
            Application.Current.MainPage = new LoginPage();
        }
    }
}