using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Forms.Street;
using eHousing.WinUI.Properties;
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
    public partial class frmCityDetails : Form
    {
        private readonly APIService cityService = new APIService("City");
        private readonly APIService streetService= new APIService("Street");
        private readonly int _Id;
        public frmCityDetails(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void frmCityDetails_Load(object sender, EventArgs e)
        {
            var city =await cityService.GetById<MCity>(_Id);
            txtCityName.Text = city.CityName;
            var StreetSearchRequest = new StreetSearchRequest
            {
                CityId = _Id
            };

            var streets = await streetService.Get<List<MStreet>>(StreetSearchRequest);

            dgvStreets.DataSource = streets;
            //Nakon dodavanje Ulica, ulice treba da se izlistaju u dgv vezane za taj grad
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var request = new CityUpsertRequest()
            {
                CityName = txtCityName.Text
            };
            await cityService.Update<MCity>(_Id, request);
            MessageBox.Show("City has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this City?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await cityService.Delete<dynamic>(_Id);
                MessageBox.Show("City succesfully deleted.");
            }
            this.Close();
        }

        private void btnAddStreet_Click(object sender, EventArgs e)
        {
            frmStreetAdd frm = new frmStreetAdd(_Id);
            frm.Show();
        }

        private void dgvStreets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = Convert.ToInt32(dgvStreets.CurrentRow.Cells["StreetId"].Value);
            frmStreetDetails frm = new frmStreetDetails(int.Parse(Id.ToString()));
            frm.Show();
        }
        private void txtCityName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCityName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCityName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtCityName, null);
            }
        }
    }
}
