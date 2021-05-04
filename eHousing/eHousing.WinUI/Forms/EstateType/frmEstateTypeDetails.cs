using eHousing.Model;
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

namespace eHousing.WinUI.Forms.EstateType
{
    public partial class frmEstateTypeDetails : Form
    {
        private readonly APIService estateTypeService = new APIService("EstateType");
        private readonly int _Id;

        public frmEstateTypeDetails(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        EstateTypeUpsertRequest request = new EstateTypeUpsertRequest();

        private async void frmEstateTypeDetails_Load(object sender, EventArgs e)
        {
            var estateType = await estateTypeService.GetById<MEstateType>(_Id);
            if (estateType.Image.Length > 3)
            {
                pictureBox1.Image = ImageHelper.ByteArrayToSystemDrawing(estateType.Image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            txtEstateTypeName.Text = estateType.EstateTypeName;
           
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var estateType = await estateTypeService.GetById<MEstateType>(_Id);

            request.EstateTypeName = txtEstateTypeName.Text;
            request.Image = pictureBox1.Image != null ? ImageHelper.SystemDrawingToByteArray(pictureBox1.Image) : null;
            await estateTypeService.Update<MEstateType>(_Id, request);
            MessageBox.Show("Estate type has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this estate type?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await estateTypeService.Delete<dynamic>(_Id);
                MessageBox.Show("Estate type succesfully deleted.");
            }
            this.Close();
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
    }
}
