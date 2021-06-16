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
    public partial class EstateGalleryPage : ContentPage
    {
        private EstateGalleryVM model = null;
        private MEstate e;
        public EstateGalleryPage(MEstate estate)
        {
            e = estate;
            InitializeComponent();
            BindingContext = model = new EstateGalleryVM(estate);
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init(e);
        }
    }
}