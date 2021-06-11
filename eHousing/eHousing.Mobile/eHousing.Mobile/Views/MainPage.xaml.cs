using eHousing.Mobile.Models;
using eHousing.Mobile.Views.Account;
using eHousing.Mobile.Views.Estates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHousing.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
        }
        public async Task NavigateFromMenu(int ID)
        {
            if (!MenuPages.ContainsKey(ID))
            {
                switch (ID)
                {
                    case (int)MenuType.Estates:
                        MenuPages.Add(ID, new NavigationPage(new EstatePage()));
                        break;
                    case (int)MenuType.EditProfile:
                        MenuPages.Add(ID, new NavigationPage(new AccountPage()));
                        break;
                    case (int)MenuType.Logout:
                        MenuPages.Add(ID, new NavigationPage(new LogoutPage()));
                        break;
                }
            }

            var newPage = MenuPages[ID];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}