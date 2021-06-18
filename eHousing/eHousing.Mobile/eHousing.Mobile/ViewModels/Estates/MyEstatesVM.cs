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
    public class MyEstatesVM:BaseVM
    {
        private readonly APIService EstateStatusService=new APIService("EstateStatus");
 
        public ObservableCollection<MEstate> myEstateList { get; set; } = new ObservableCollection<MEstate>();
        public ICommand InitCommand { get; set; }
        public MyEstatesVM()
        {
            InitCommand = new Command(async () => await Init());

        }

        public async Task Init()
        {
            myEstateList.Clear();

            var request = new EstateStatusSearchRequest();

            request.UserId = SignedInUser.User.UserId;

            var myEstates = await EstateStatusService.Get<List<MEstateStatus>>(request);

            foreach(var es in myEstates)
            {

                if ((bool)es.Estate.IsOccupied)
                {
                    es.Estate.Status = "Occupied";
                }
                else
                {
                    es.Estate.Status = "Available";
                }
                myEstateList.Add(es.Estate);
            }


        }
    }
}
