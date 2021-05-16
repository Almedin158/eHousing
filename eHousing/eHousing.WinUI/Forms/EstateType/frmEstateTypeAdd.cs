using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Properties;
using Newtonsoft.Json;
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
    public partial class frmEstateTypeAdd : Form
    {
        private readonly APIService estateTypeService = new APIService("EstateType");
        public frmEstateTypeAdd()
        {
            InitializeComponent();
        }
        EstateTypeUpsertRequest request = new EstateTypeUpsertRequest();
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
            
            if (request.Image != null && txtEstateTypeName.Text!=null)
            {
                request.EstateTypeName = txtEstateTypeName.Text;
                await estateTypeService.Insert<MEstateType>(request);
                MessageBox.Show("Estate type added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Not all fields are correctly inserted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        private void txtEstateTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstateTypeName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEstateTypeName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEstateTypeName, null);
            }
        }
    }
}
