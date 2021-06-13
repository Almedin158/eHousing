using eHousing.Mobile.Helpers;
using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class SearchEstateVM : BaseVM
    {
        private readonly APIService cityService = new APIService("City");
        private readonly APIService streetService = new APIService("Street");
        private readonly APIService estateTypeService = new APIService("EstateType");
        private readonly APIService estateService = new APIService("Estate");
        public ObservableCollection<MCity> cityList { get; set; } = new ObservableCollection<MCity>();
        public ObservableCollection<MStreet> streetList { get; set; } = new ObservableCollection<MStreet>();
        public ObservableCollection<MEstateType> estateTypeList { get; set; } = new ObservableCollection<MEstateType>();
        public ObservableCollection<MEstate> estateList { get; set; } = new ObservableCollection<MEstate>();
        public ICommand InitCommand { get; set; }

        readonly MUser user = SignedInUser.User;
        public SearchEstateVM()
        {
            InitCommand = new Command(async () => await Init(user));
            
        }


        StreetSearchRequest streetSearchRequest = new StreetSearchRequest();

        public async void FillStreets(int Id)
        {
            streetSearchRequest.CityId = Id;
            var streets = await streetService.Get<List<MStreet>>(streetSearchRequest);
            foreach (var street in streets)
            {
                streetList.Add(street);
            }
        }

        MCity _selectedCity = null;
        public MCity SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                
                SetProperty(ref _selectedCity, value);
                streetList.Clear();
                FillStreets(_selectedCity.CityId);
                if (value != null)
                    InitCommand.Execute(null);

            }
        }

        MStreet _selectedStreet = null;

        public MStreet SelectedStreet
        {
            get { return _selectedStreet; }
            set
            {
                SetProperty(ref _selectedStreet, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        MEstateType _selectedEstateType = null;

        public MEstateType SelectedEstateType
        {
            get { return _selectedEstateType; }
            set
            {
                SetProperty(ref _selectedEstateType, value);
                if (value != null)
                    InitCommand.Execute(null);

            }
        }

        bool _petsAllowed;
        public bool PetsAllowed
        {
            get { return _petsAllowed; }
            set
            {
                SetProperty(ref _petsAllowed, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        int _minPrice;

        public int MinPrice
        {
            get { return _minPrice; }
            set
            {
                SetProperty(ref _minPrice, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        int _maxPrice;

        public int MaxPrice
        {
            get { return _maxPrice; }
            set
            {
                SetProperty(ref _maxPrice, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        bool _occupied;
        public bool Occupied
        {
            get { return _occupied; }
            set
            {
                SetProperty(ref _occupied, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

   

        public async Task Init(MUser user)
        {
            if (cityList.Count == 0)
            {
                cityList.Clear();
                var cities = await cityService.Get<List<MCity>>(null);
                foreach (var city in cities)
                {
                    cityList.Add(city);
                }
            }

            if (estateTypeList.Count == 0)
            {
                estateTypeList.Clear();
                var types = await estateTypeService.Get<List<MEstateType>>(null);
                foreach (var type in types)
                {
                    estateTypeList.Add(type);
                }
            }
            estateList.Clear();

            EstateSearchRequest estateSearchRequest = new EstateSearchRequest();

            estateSearchRequest.PetsAllowed = _petsAllowed;
            estateSearchRequest.IsOccupied = _occupied;
            estateSearchRequest.MinPrice = _minPrice;
            estateSearchRequest.MaxPrice = _maxPrice;

            if (SelectedCity != null)
            {
                estateSearchRequest.CityId = SelectedCity.CityId;
            }
            if (SelectedStreet != null)
            {
                estateSearchRequest.StreetId = SelectedStreet.StreetId;
            }
            if (SelectedEstateType != null)
            {
                estateSearchRequest.EstateTypeId = _selectedEstateType.EstateTypeId;
            }

            var estates = await estateService.Get<List<MEstate>>(estateSearchRequest);
            foreach (var estate in estates)
            {
                if (estate.IsOccupied)
                {
                    estate.Status = "Occupied";
                }
                else
                {
                    estate.Status = "Available";
                }
                estateList.Add(estate);
                
                
            }
        }

       
    }
}
