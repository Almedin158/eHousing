using eHousing.Mobile.Helpers;
using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class FavoriteEstateVM : BaseVM
    {
        private readonly APIService favoriteEstateService = new APIService("FavoriteEstate");
        public ObservableCollection<MEstate> myFavoriteEstateList { get; set; } = new ObservableCollection<MEstate>();

        public ICommand InitCommand { get; set; }
        public FavoriteEstateVM()
        {
            InitCommand = new Command(async () => await Init());

        }

        public async Task Init()
        {
            myFavoriteEstateList.Clear();
            var request = new FavoriteEstateSearchRequest()
            {
                UserId = SignedInUser.User.UserId
            };

            var favorites = await favoriteEstateService.Get<List<MFavoriteEstate>>(request);

            foreach(var f in favorites)
            {
                if ((bool)f.Estate.IsOccupied)
                {
                    f.Estate.Status = "Occupied";
                }
                else
                {
                    f.Estate.Status = "Available";
                }
                myFavoriteEstateList.Add(f.Estate);
            }
        }


    }




}
