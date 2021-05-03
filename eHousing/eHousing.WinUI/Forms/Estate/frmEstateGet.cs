using eHousing.Model;
using eHousing.Model.Request;
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
    public partial class frmEstateGet : Form
    {
        APIService estateService = new APIService("Estate");
        APIService cityService = new APIService("City");
        APIService estateTypeService = new APIService("EstateType");
        APIService streetService = new APIService("Street");
        public frmEstateGet()
        {
            InitializeComponent();
        }

        private async void frmEstateGet_Load(object sender, EventArgs e)
        {
            await LoadList();
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
            streets.Insert(0, new MStreet { StreetName = "All City Streets" });
            cbStreet.DataSource = streets;
            cbStreet.ValueMember = "StreetId";
            cbStreet.DisplayMember = "StreetName";

            EstateSearchRequest request = new EstateSearchRequest()
            {
                CityId = cityId,
                EstateTypeId = Convert.ToInt32(cbEstateType.SelectedValue)
            };
            await LoadList(request);
        }
        private async Task LoadList()
        {
            var cities = await cityService.Get<List<MCity>>(null);
            cities.Insert(0, new MCity { CityName = "All Cities" });
            cbCity.DataSource = cities;
            cbCity.ValueMember = "CityId";
            cbCity.DisplayMember = "CityName";

            var streets = await streetService.Get<List<MStreet>>(null);
            streets.Insert(0, new MStreet { StreetName = "All Streets" });
            cbStreet.DataSource = streets;
            cbStreet.ValueMember = "StreetId";
            cbStreet.DisplayMember = "StreetName";

            var estatetypes = await estateTypeService.Get<List<MEstateType>>(null);
            estatetypes.Insert(0, new MEstateType { EstateTypeName = "All Estate Types" });
            cbEstateType.DataSource = estatetypes;
            cbEstateType.ValueMember = "EstateTypeId";
            cbEstateType.DisplayMember = "EstateTypeName";

            var result = await estateService.Get<List<MEstate>>(null);
            dgvEstates.DataSource = result;
        }
        private async Task LoadList(EstateSearchRequest request)
        {
            var result = await estateService.Get<List<MEstate>>(request);
            dgvEstates.DataSource = result;
        }

        private async void cbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStreet.ValueMember = "StreetId";
            cbStreet.DisplayMember = "StreetName";
            EstateSearchRequest request = new EstateSearchRequest()
            {
                CityId = Convert.ToInt32(cbCity.SelectedValue),
                StreetId= Convert.ToInt32(cbStreet.SelectedValue),
                EstateTypeId = Convert.ToInt32(cbEstateType.SelectedValue)
            };
            await LoadList(request);
        }

        private async void cbEstateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstateType.ValueMember = "EstateTypeId";
            cbEstateType.DisplayMember = "EstateTypeName";
            EstateSearchRequest request = new EstateSearchRequest()
            {
                CityId = Convert.ToInt32(cbCity.SelectedValue),
                StreetId = Convert.ToInt32(cbStreet.SelectedValue),
                EstateTypeId = Convert.ToInt32(cbEstateType.SelectedValue)
            };
            await LoadList(request);
        }
    }
}
