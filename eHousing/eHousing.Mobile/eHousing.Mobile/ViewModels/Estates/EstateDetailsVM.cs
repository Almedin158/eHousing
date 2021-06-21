using eHousing.Mobile.Helpers;
using eHousing.Mobile.Views.Estates;
using eHousing.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class EstateDetailsVM:BaseVM
    {

        private readonly APIService favoriteEstateService = new APIService("FavoriteEstate");
        private readonly APIService userService = new APIService("User");

        private MUser _user;
        public MUser User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }
        public ICommand EmailCommand { get; set; }

        private MEstate _estate;
        public MEstate Estate
        {
            get { return _estate; }
            set { SetProperty(ref _estate, value); }
        }

        private int _months;
        public int Months
        {
            get { return _months; }
            set
            {
                SetProperty(ref _months, value);
            }
        }

        public EstateDetailsVM()
        {
       
        }
        public EstateDetailsVM(MEstate estate)
        {
            Estate = estate;
            User = Estate.User;
            EmailCommand = new Command(async () => await ExecuteEmailCommand());


        }

        async Task ExecuteEmailCommand()
        {
            try
            {
                await Email.ComposeAsync(string.Empty, string.Empty, User.Email);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }


    }
}
