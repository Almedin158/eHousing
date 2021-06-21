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
    public partial class RentedEstateDetailPage : ContentPage
    {
        private RentedEstateDetailVM model = null;
        private readonly APIService reviewService = new APIService("UserEstateReview");
        public MEstate est;
        public RentedEstateDetailPage(MEstate estate)
        {
            est = estate;
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

        private async void SfRating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            int Rate = Convert.ToInt32(e.Value);
            var request = new UserEstateReviewSearchRequest()
            {
                UserId = SignedInUser.User.UserId,
                EstateId = model.Estate.EstateId,
                Rating = Rate
            };

            if (model.EstateReview == null)
            {
                model.EstateReview = await reviewService.Insert<MUserEstateReview>(request);
            }
            else if (model.EstateReview != null && model.Rating == 0)
            {
                await reviewService.Delete<MUserEstateReview>(model.EstateReview.UserEstateReviewId);
            }
            else
            {
                await reviewService.Update<MUserEstateReview>(model.EstateReview.UserEstateReviewId, request);
            }
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