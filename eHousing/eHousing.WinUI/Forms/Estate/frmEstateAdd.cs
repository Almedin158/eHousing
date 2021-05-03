﻿using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Helper;
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
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.StreetId=Convert.ToInt32(cbStreet.SelectedValue);
            request.EstateTypeId= Convert.ToInt32(cbEstateType.SelectedValue);
            request.EstateName = txtEstateName.Text;
            request.Price = Convert.ToInt32(txtPrice.Text);
            request.FloorSpace = Convert.ToInt32(txtFloorSpace.Text);
            request.NumberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
            request.PetsAllowed = cbPetsAllowed.Checked;
            request.EstateDescription = txtEstateDescription.Text;
            request.UserId = _user.UserId;
            request.CreationDate = DateTime.Now;
            await estateService.Insert<MEstate>(request);
            MessageBox.Show("Estate type added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}