using eHousing.Mobile.ViewModels.Estates;
using eHousing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHousing.Mobile.Views.Estates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEstatesPage : ContentPage
    {
        private MyEstatesVM modelMyEstates = null;
        public MyEstatesPage()
        {

            InitializeComponent();
            BindingContext = modelMyEstates = new MyEstatesVM();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await modelMyEstates.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var estate = e.SelectedItem as MEstate;
            await Navigation.PushAsync(new RentedEstateDetailPage(estate));
        }
    }
}