using eHousing.Mobile.Helpers;
using eHousing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class RecommendedEstatesVM:BaseVM
    {
        private readonly APIService recommendedEstatesService = new APIService("Recommendation");
        private readonly APIService estateStatusService = new APIService("EstateStatus");
        public ObservableCollection<MEstate> recommendedEstatesList { get; set; } = new ObservableCollection<MEstate>();

        public ICommand InitCommand { get; set; }

        public RecommendedEstatesVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            try
            {
                if (SignedInUser.User != null)
                {   
                    int userId = SignedInUser.User.UserId;
                    recommendedEstatesList.Clear();
                    var recommendEstates = await recommendedEstatesService.GetRecommandedEstates(userId);
                    foreach (var estate in recommendEstates)
                    {
                        if ((bool)estate.IsOccupied)
                        {
                            estate.Status = "Occupied";
                        }
                        else
                        {
                            estate.Status = "Available";
                        }
                        recommendedEstatesList.Add(estate);
                    }
                }

            }
            catch
            {

            }
        }
    }
}
