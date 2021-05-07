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

namespace eHousing.WinUI.Forms.Street
{
    public partial class frmStreetDetails : Form
    {
        private readonly APIService streetService = new APIService("Street");
        private readonly APIService estateService = new APIService("Estate");
        private readonly int _Id;
        public frmStreetDetails(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void frmStreetDetails_Load(object sender, EventArgs e)
        {
            var street = await streetService.GetById<MStreet>(_Id);
            txtStreetName.Text = street.StreetName;
            EstateSearchRequest request = new EstateSearchRequest
            {
                StreetId = _Id
            };
            var result = await estateService.Get<List<MEstate>>(request);
            dgvEstates.AutoGenerateColumns = false;
            dgvEstates.DataSource = result;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var request = new StreetUpsertRequest()
            {
                StreetName = txtStreetName.Text
            };
            await streetService.Update<MStreet>(_Id, request);
            MessageBox.Show("Street has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
