using eHousing.Mobile.Helpers;
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
    public partial class SearchEstatePage : ContentPage
    {
        public APIService estateService = new APIService("Estate");
        private SearchEstateVM modelSearchEstate= null;

        public SearchEstatePage()
        {
            InitializeComponent();
            BindingContext = modelSearchEstate = new SearchEstateVM();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await modelSearchEstate.Init();

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var estate = e.SelectedItem as MEstate;
            await Navigation.PushAsync(new EstateDetailPage(estate));
        }
    }
}