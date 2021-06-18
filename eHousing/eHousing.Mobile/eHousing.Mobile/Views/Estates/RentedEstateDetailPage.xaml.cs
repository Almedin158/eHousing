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
    public partial class RentedEstateDetailPage : ContentPage
    {
        private RentedEstateDetailVM model = null;
        public RentedEstateDetailPage(MEstate estate)
        {
            InitializeComponent();
            BindingContext = model = new RentedEstateDetailVM()
            {
                Estate = estate
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();



        }

        private async void btnGallery_Clicked(object sender, EventArgs e)
        {
            var estate = model.Estate;
            await Navigation.PushAsync(new EstateGalleryPage(estate));
        }
    }
}