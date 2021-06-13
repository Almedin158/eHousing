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
        MUser _user;

        public SearchEstatePage()
        {
            InitializeComponent();
            BindingContext = modelSearchEstate = new SearchEstateVM();
        }
        public SearchEstatePage(MUser user)
        {
            InitializeComponent();
            _user = user;
            SignedInUser.User = user;
            BindingContext = modelSearchEstate = new SearchEstateVM();
           
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await modelSearchEstate.Init(_user);
            
            
            
        }
    }
}