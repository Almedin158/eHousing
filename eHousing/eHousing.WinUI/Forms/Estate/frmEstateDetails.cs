using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Helper;
using eHousing.WinUI.Properties;
using eHousing.WinUI.ReportForms;
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
    public partial class frmEstateDetails : Form
    {
        private readonly APIService estateService = new APIService("Estate");
        private readonly APIService cityService = new APIService("City");
        private readonly APIService streetService = new APIService("Street");
        private readonly APIService estateTypeService = new APIService("EstateType");
        private readonly int _Id;
        public frmEstateDetails(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }
        EstateUpsertRequest request = new EstateUpsertRequest();

        private async void frmEstateDetails_Load(object sender, EventArgs e)
        {
            var estate = await estateService.GetById<MEstate>(_Id);
            var street = await streetService.GetById<MStreet>(estate.StreetId);
            var city = await cityService.GetById<MCity>(street.CityId);
            var estateType = await estateTypeService.GetById<MEstateType>(estate.EstateTypeId);
            txtCity.Text = city.CityName;
            txtStreet.Text = street.StreetName;
            txtEstateType.Text = estateType.EstateTypeName;
            txtEstateName.Text = estate.EstateName;
            txtPrice.Text = estate.Price.ToString();
            txtFloorSpace.Text = estate.FloorSpace.ToString();
            txtNumberOfRooms.Text = estate.NumberOfRooms.ToString();
            cbPetsAllowed.Checked = (bool)estate.PetsAllowed;
            cbOccupied.Checked = (bool)estate.IsOccupied;
            txtEstateDescription.Text = estate.EstateDescription;
            if (estate.Image.Length > 3)
            {
                pictureBox1.Image = ImageHelper.ByteArrayToSystemDrawing(estate.Image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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
            var estate = await estateService.GetById<MEstate>(_Id);

            if (ValidateChildren()) {
            request.StreetId = estate.StreetId;
            request.EstateTypeId = estate.EstateTypeId;
            request.EstateName = txtEstateName.Text;
            request.Price =Convert.ToInt32(txtPrice.Text);
            request.FloorSpace = Convert.ToInt32(txtFloorSpace.Text);
            request.NumberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
            request.IsOccupied = cbOccupied.Checked;
            request.PetsAllowed = cbPetsAllowed.Checked;
            request.EstateDescription = txtEstateDescription.Text;
            request.Image = pictureBox1.Image != null ? ImageHelper.SystemDrawingToByteArray(pictureBox1.Image) : null;
            request.UserId = estate.UserId;
            request.CreationDate = estate.CreationDate;
            await estateService.Update<MEstate>(_Id, request);
            MessageBox.Show("Estate has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnPhotoGallery_Click(object sender, EventArgs e)
        {
            frmEstateGallery frm = new frmEstateGallery(_Id);
            frm.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this Estate?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await estateService.Delete<dynamic>(_Id);
                MessageBox.Show("Estate succesfully deleted.");
            }
            this.Close();
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

        private void btnEstateReport_Click(object sender, EventArgs e)
        {
            frmMyEstateRentDetails frm = new frmMyEstateRentDetails(_Id);
            frm.Show();
        }
    }
}
