using eHousing.Model.Model;
using eHousing.Model.Model.Request;
using eHousing.WinUI.Helper;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHousing.WinUI.Forms.User
{
    public partial class frmUserGet : Form
    {

        private MUser _user;
        APIService _service = new APIService("User");
        public frmUserGet(MUser user)
        {
            _user = user;
            SignedInUser.User = _user;
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch == null) {
                var result = await _service.Get<List<MUser>>(null);
                dgvUsers.DataSource = result;
            }
            else
            {
                var request = new UserSearchRequest()
                {
                    FirstName = txtSearch.Text
                };
                var result = await _service.Get<List<MUser>>(request);
                dgvUsers.DataSource = result;
            }
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
            frmUserDetails frm = new frmUserDetails(_user, int.Parse(Id.ToString()));
            frm.Show();
        }

        private async void frmUserGet_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoGenerateColumns = false;
            var result = await _service.Get<List<MUser>>(null);
            dgvUsers.DataSource = result;
        }
    }
}
