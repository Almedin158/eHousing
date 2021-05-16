using eHousing.Model;
using eHousing.Model.Request;
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
    public partial class frmCityAdd : Form
    {
        private readonly APIService cityService = new APIService("City");
        public frmCityAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) { 
            var request = new CityUpsertRequest()
            {
                CityName = txtCityName.Text
            };
            await cityService.Insert<MCity>(request);
            MessageBox.Show("City added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
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
