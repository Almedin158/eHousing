using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHousing.WinUI.Forms.Estate
{
    public partial class frmEstateAdd : Form
    {
        private readonly APIService cityService = new APIService("City");
        private readonly APIService streetService = new APIService("Street");
        private readonly APIService estateTypeService = new APIService("EstateType");
        private readonly APIService estateService = new APIService("Estate");
        private MUser _user;
        public frmEstateAdd(MUser user)
        {
            _user = user;
            SignedInUser.User = _user;
            InitializeComponent();
        }

        private async void frmEstateAdd_Load(object sender, EventArgs e)
        {
            var cities = await cityService.Get<List<MCity>>(null);
            cbCity.DataSource = cities;
            cbCity.ValueMember = "CityId";
            cbCity.DisplayMember = "CityName";

            var estatetypes = await estateTypeService.Get<List<MEstateType>>(null);

            cbEstateType.DataSource = estatetypes;
            cbEstateType.ValueMember = "EstateTypeId";
            cbEstateType.DisplayMember = "EstateTypeName";
        }

        private async void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStreet.SelectedIndex = -1;
            cbCity.ValueMember = "CityId";
            cbCity.DisplayMember = "CityName";
            var cityId = Convert.ToInt32(cbCity.SelectedValue);

            StreetSearchRequest streetRequest = new StreetSearchRequest
            {
                CityId = cityId
            };
            var streets = await streetService.Get<List<MStreet>>(streetRequest);

            cbStreet.DataSource = streets;
            cbStreet.ValueMember = "StreetId";
            cbStreet.DisplayMember = "StreetName";
        }
    }
}
