using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Helper;
using eHousing.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        EstateUpsertRequest request = new EstateUpsertRequest();

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

        private void btnBrowsePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                var fileName = open.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Image = file;

                Image img = Image.FromFile(fileName);
                pictureBox1.Image = img;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (request.Image != null)
            {
                if (ValidateChildren())
                {
                    request.StreetId = Convert.ToInt32(cbStreet.SelectedValue);
                    request.EstateTypeId = Convert.ToInt32(cbEstateType.SelectedValue);
                    request.EstateName = txtEstateName.Text;
                    request.Price = Convert.ToInt32(txtPrice.Text);
                    request.FloorSpace = Convert.ToInt32(txtFloorSpace.Text);
                    request.NumberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
                    request.PetsAllowed = cbPetsAllowed.Checked;
                    request.EstateDescription = txtEstateDescription.Text;
                    request.UserId = _user.UserId;
                    request.CreationDate = DateTime.Now;
                    request.IsOccupied = false;
                    await estateService.Insert<MEstate>(request);
                    MessageBox.Show("Estate added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("All fields are required.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All fields are required.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCity.Text))
            {
                MessageBox.Show("Please select a value");
            }

            else
            {

                errorProvider1.SetError(cbCity, null);

            }

        }
        private void cbStreet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbStreet.Text))
            {
                MessageBox.Show("Please select a value");
            }

            else
            {

                errorProvider1.SetError(cbStreet, null);

            }

        }
        private void cbEstateType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEstateType.Text))
            {
                MessageBox.Show("Please select a value");
            }

            else
            {

                errorProvider1.SetError(cbEstateType, null);

            }

        }
        private void txtEstateName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstateName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEstateName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEstateName, null);
            }
        }
        private void txtEstateDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstateDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEstateDescription, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEstateDescription, null);
            }
        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string price = txtPrice.Text.ToString();
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Price field can't be empty");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
                if (IsDigitsOnly(price) == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPrice, "You can't use letters!");
                }
                else
                {
                    errorProvider1.SetError(txtPrice, null);
                }
            }
        }
        private void txtFloorSpace_Validating(object sender, CancelEventArgs e)
        {
            string floorspace = txtFloorSpace.Text.ToString();
            if (string.IsNullOrWhiteSpace(txtFloorSpace.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFloorSpace, "Price field can't be empty");
            }
            else
            {
                errorProvider1.SetError(txtFloorSpace, null);
                if (IsDigitsOnly(floorspace) == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtFloorSpace, "You can't use letters!");
                }
                else
                {
                    errorProvider1.SetError(txtFloorSpace, null);
                }
            }
        }
        private void txtNumberOfRooms_Validating(object sender, CancelEventArgs e)
        {
            string numberOfRooms = txtNumberOfRooms.Text.ToString();
            if (string.IsNullOrWhiteSpace(txtNumberOfRooms.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNumberOfRooms, "Price field can't be empty");
            }
            else
            {
                errorProvider1.SetError(txtNumberOfRooms, null);
                if (IsDigitsOnly(numberOfRooms) == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNumberOfRooms, "You can't use letters!");
                }
                else
                {
                    errorProvider1.SetError(txtNumberOfRooms, null);
                }
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
