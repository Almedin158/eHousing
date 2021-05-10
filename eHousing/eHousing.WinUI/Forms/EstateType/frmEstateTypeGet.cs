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

namespace eHousing.WinUI.Forms.EstateType
{
    public partial class frmEstateTypeGet : Form
    {
        private readonly APIService estateTypeService = new APIService("EstateType");
        public frmEstateTypeGet()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch == null)
            {
                var result = await estateTypeService.Get<List<MEstateType>>(null);
                dgvEstateType.DataSource = result;
            }
            else
            {
                var request = new EstateTypeSearchRequest()
                {
                    EstateTypeName = txtSearch.Text
                };
                var result = await estateTypeService.Get<List<MEstateType>>(request);
                dgvEstateType.DataSource = result;//Izbaci error ako slika nije dodata ranije
            }
        }

        private void dgvEstateType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = Convert.ToInt32(dgvEstateType.CurrentRow.Cells["EstateTypeId"].Value);
            frmEstateTypeDetails frm = new frmEstateTypeDetails(int.Parse(Id.ToString()));
            frm.Show();
        }

        private void frmEstateTypeGet_Load(object sender, EventArgs e)
        {
            dgvEstateType.RowTemplate.Height = 90;
        }
    }
}
