using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Forms.User;
using eHousing.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHousing.WinUI
{
    public partial class Login : Form
    {
        APIService _service = new APIService("User");
        private MUser _user;
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            var request = new UserAuthenticationRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            var user = await _service.Authenticate(request);

            if (user != null)
            {
                var form = new frmIndex(user);
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password!");
            }
            //this.Hide();
        }
    }
}
