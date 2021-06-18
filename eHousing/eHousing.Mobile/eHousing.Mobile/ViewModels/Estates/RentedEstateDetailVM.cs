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
    public class RentedEstateDetailVM:BaseVM
    {
        private readonly APIService estateStatusService = new APIService("EstateStatus");
        
        public ICommand InitCommand { get; set; }

        private MEstate _estate;
        public MEstate Estate
        {
            get { return _estate; }
            set { SetProperty(ref _estate, value); }
        }

        private DateTime since;

        public DateTime Since
        {
            get { return since; }
            set
            {
                SetProperty(ref since, value);
            }
        }

        private DateTime till;

        public DateTime Till
        {
            get { return till; }
            set
            {
                SetProperty(ref till, value);
            }
        }

        public RentedEstateDetailVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public RentedEstateDetailVM(MEstate estate)
        {
            Estate = estate;
            InitCommand = new Command(async () => await Init());

        }

        public async Task Init()
        {
            var request = new EstateStatusSearchRequest()
            {
                EstateId = Estate.EstateId,
                UserId = SignedInUser.User.UserId
            };
            var estateStatuses = await estateStatusService.Get<List<MEstateStatus>>(request);

            Since = estateStatuses[0].OccupiedSince;
            Till = estateStatuses[0].OccupiedTill;
        }
    }
}
