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
    public partial class RecommendedEstatesPage : ContentPage
    {
        private RecommendedEstatesVM model = null;
        public RecommendedEstatesPage()
        {
            InitializeComponent();
            BindingContext = model = new RecommendedEstatesVM();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }

        
        private async void ListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var estate = e.SelectedItem as MEstate;
            await Navigation.PushAsync(new EstateDetailPage(estate));
        }
    }
}