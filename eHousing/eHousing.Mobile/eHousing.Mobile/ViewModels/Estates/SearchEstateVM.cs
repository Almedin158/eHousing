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
    public class SearchEstateVM:BaseVM
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

        MCity _selectedCity = null;

        public MCity SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                SetProperty(ref _selectedCity, value);
                if (value != null)
                    InitCommand.Execute(null);
                //subcategoryList.Clear();
                //getSubcategories();

            }
        }

        MStreet _selectedStreet = null;

        public MStreet SelectedStreet
        {
            get { return _selectedStreet; }
            set
            {
                SetProperty(ref _selectedStreet, value);
                //subcategoryList.Clear();
                //getSubcategories();

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
        public async Task Init(MUser user)
        {

            try
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
                if (SelectedEstateType != null)
                {
                    EstateSearchRequest search = new EstateSearchRequest
                    {
                        EstateTypeId = SelectedEstateType.EstateTypeId
                    };

                    var estates = await estateService.Get<List<MEstate>>(search);
                    foreach (var estate in estates)
                    {
                        estateList.Add(estate);
                    }
                }

                if (SelectedCity != null)
                {
                    int userID;
                    //if (SelectedStreet == null)
                    //{
                        //EstateSearchRequest search1 = new EstateSearchRequest
                        //{
                        //    StreetId = SelectedStreet.StreetId
                        //};
                        //estateList.Clear();


                        StreetSearchRequest streetSearchRequest = new StreetSearchRequest()
                        {
                            CityId = SelectedCity.CityId
                        };

                        streetList.Clear();
                        var streets = await streetService.Get<List<MStreet>>(streetSearchRequest);
                        foreach (var street in streets)
                        {
                            streetList.Add(street);
                        }


                        //var estates = await estateService.Get<List<MEstate>>(search1);

                        //foreach (var x in estates)
                        //{

                        //    userID = SignedInUser.User.UserId;
                        //    //var usersRentEstates = await estateService.GetRentedEstates(userId);
                        //    //var DoesItContain = usersRentEstates.Where(m => m.EstateId == x.EstateId).Any();
                        //    if (x.UserId != user.UserId)
                        //    {
                        //        estateList.Add(x);
                        //    }
                        //    //if (usersBoughtCourses.Count > 0)
                        //    //{
                        //        //if (DoesItContain == false && x.UserID != user.UserID)
                        //        //{
                        //            //courseList.Add(new CourseVM(x));
                        //        //}
                        //    //}
                        //    //else if (x.UserID != user.UserID)
                        //    //{
                        //    //    courseList.Add(new CourseVM(x));
                        //    //}
                        //}
                    //}
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
