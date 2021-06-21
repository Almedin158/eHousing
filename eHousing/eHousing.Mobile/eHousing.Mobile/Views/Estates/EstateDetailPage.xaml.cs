using Acr.UserDialogs;
using eHousing.Mobile.Helpers;
using eHousing.Mobile.ViewModels.Estates;
using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHousing.Mobile.Views.Estates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstateDetailPage : ContentPage
    {
        private EstateDetailsVM model = null;

        private readonly APIService favoriteEstatesService = new APIService("FavoriteEstate");
        private readonly APIService userService = new APIService("User");
        MEstate est;
        public EstateDetailPage(MEstate estate)
        {

            InitializeComponent();
            est = estate;
            BindingContext = model = new EstateDetailsVM()
            {
                Estate = estate
            };
            

        }
    
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var request = new FavoriteEstateSearchRequest
            {
                EstateId=est.EstateId,
                UserId=SignedInUser.User.UserId
            };
            var favorite = await favoriteEstatesService.Get<List<MFavoriteEstate>>(request);
            if (favorite.Count() != 0)
            {
                btnAddFavorite.IsVisible = false;
                btnRemoveFavorite.IsVisible = true;
            }
            else
            {
                btnRemoveFavorite.IsVisible = false;
                btnAddFavorite.IsVisible = true;
            }
               
            
         
        }

        private async void btnGallery_Clicked(object sender, EventArgs e)
        {
            var estate = model.Estate;
            await Navigation.PushAsync(new EstateGalleryPage(estate));
        }

        private async void btnRent_Clicked(object sender, EventArgs e)
        {
            if (model.Months == 0)
            {
                UserDialogs.Instance.Alert("Please insert a valid number of months!");
                return;
            }
            var estate = model.Estate;
            var months = model.Months;
            await Navigation.PushAsync(new PaymentPage(estate,months));
        }

        private async void btnAddFavorite_Clicked(object sender, EventArgs e)
        {
            var req = new FavoriteEstateUpsertRequest()
            {
                EstateId = est.EstateId,
                UserId = SignedInUser.User.UserId
            };
            await userService.InsertFavoriteEstate(req.UserId,req.EstateId);
            var estate = model.Estate;
            await Navigation.PushAsync(new EstateDetailPage(estate));



        }

        private async void btnRemoveFavorite_Clicked(object sender, EventArgs e)
        {
            var req = new FavoriteEstateUpsertRequest()
            {
                EstateId = est.EstateId,
                UserId=SignedInUser.User.UserId
            };
            await userService.DeleteFavoriteEstate(req.UserId,req.EstateId);
            var estate = model.Estate;
            await Navigation.PushAsync(new EstateDetailPage(estate));
        }

        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }

        private async void btnContact_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Email.ComposeAsync(string.Empty, string.Empty, est.User.Email);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
    }
}