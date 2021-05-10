using eHousing.Model;
using eHousing.Model.Request;
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
    public partial class frmEstateGallery : Form
    {
        private readonly APIService pictureService = new APIService("Picture");
        private readonly int _Id;
        public frmEstateGallery(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void frmEstateGallery_Load(object sender, EventArgs e)
        {
            dgvGallery.RowTemplate.Height = 90;
            PictureSearchRequest request = new PictureSearchRequest
            {
                EstateId = _Id
            };
            var result = await pictureService.Get<List<MPicture>>(request);
            dgvGallery.DataSource = result;
        }

        PictureUpsertRequest request = new PictureUpsertRequest();

        private void btnBrowseImage_Click(object sender, EventArgs e)
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

        private async void btnSaveImage_Click(object sender, EventArgs e)
        {
            request.EstateId = _Id;
            await pictureService.Insert<MPicture>(request);
            MessageBox.Show("Picture added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
