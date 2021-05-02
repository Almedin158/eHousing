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

namespace eHousing.WinUI.Forms.City
{
    public partial class frmCityGet : Form
    {
        private readonly APIService cityService = new APIService("City");
        public frmCityGet()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSearch == null)
            {
                var result = await cityService.Get<List<MCity>>(null);
                dgvCity.DataSource = result;
            }
            else
            {
                var request = new CitySearchRequest()
                {
                    CityName = txtSearch.Text
                };
                var result = await cityService.Get<List<MCity>>(request);
                dgvCity.DataSource = result;
            }
        }

        private void dgvCity_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = Convert.ToInt32(dgvCity.CurrentRow.Cells["CityId"].Value);
            frmCityDetails frm = new frmCityDetails(int.Parse(Id.ToString()));
            frm.Show();
        }

        private async void frmCityGet_Load(object sender, EventArgs e)
        {
            var result = await cityService.Get<List<MCity>>(null);
            dgvCity.DataSource = result;
        }
    }
}
