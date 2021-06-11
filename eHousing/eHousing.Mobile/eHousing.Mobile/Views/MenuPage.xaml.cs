using eHousing.Mobile.Models;
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
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<MenuItems> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            menuItems = new List<MenuItems>
            {
                new MenuItems {ID = MenuType.Estates, Title="Estates" },
                new MenuItems {ID = MenuType.EditProfile, Title="Edit profile" },
                new MenuItems {ID = MenuType.Logout, Title="Logout" }
            };
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var ID = (int)((MenuItems)e.SelectedItem).ID;
                await RootPage.NavigateFromMenu(ID);
            };
        }
    }
}