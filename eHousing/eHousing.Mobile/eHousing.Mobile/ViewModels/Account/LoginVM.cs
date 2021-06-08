using eHousing.Mobile.Helpers;
using eHousing.Mobile.Views;
using eHousing.Mobile.Views.Account;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Account
{
    public class LoginVM : BaseVM
    {
        private readonly APIService userService = new APIService("User");

        string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public LoginVM()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(() => RegisterLoad());
        }
        void RegisterLoad()
        {
            Application.Current.MainPage = new RegisterPage();
        }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            var request = new UserAuthenticationRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            var user = await userService.Authenticate(request);

            if (user != null)
            {
                Application.Current.MainPage = new MainPage();
                SignedInUser.User = user;
                //new LikeHelper();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Enter a valid Username and Password!", "OK");
            }
        }
    }
}
