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

namespace eHousing.WinUI.Forms.Estate
{
    public partial class frmMyEstates : Form
    {
        APIService estateService = new APIService("Estate");
        private readonly int _Id;
        public frmMyEstates(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void frmMyEstates_Load(object sender, EventArgs e)
        {
            var request = new EstateUpsertRequest
            {
                UserId = _Id
            };
            var result = await estateService.Get<List<MEstate>>(request);
            dgvMyEstates.DataSource = result;
        }

        private void dgvMyEstates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = Convert.ToInt32(dgvMyEstates.CurrentRow.Cells["EstateId"].Value);
            frmEstateDetails frm = new frmEstateDetails(int.Parse(Id.ToString()));
            frm.Show();
        }
    }
}
