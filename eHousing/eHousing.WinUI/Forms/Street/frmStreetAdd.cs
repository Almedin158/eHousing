using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Forms.City;
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

namespace eHousing.WinUI.Forms.Street
{
    public partial class frmStreetAdd : Form
    {
        private readonly APIService streetService = new APIService("Street");
        private readonly int _Id;
        public frmStreetAdd(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) {
            var request = new StreetUpsertRequest
            {
                CityId = _Id,
                StreetName = txtStreetName.Text
            };

            await streetService.Insert<MStreet>(request);
            MessageBox.Show("Street added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields are required.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtStreetName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStreetName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStreetName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtStreetName, null);
            }
        }
    }
}
