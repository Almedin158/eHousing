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

namespace eHousing.WinUI.Forms.User
{
    public partial class frmUserChangePassword : Form
    {
        private readonly APIService userService = new APIService("User");
        private readonly int _Id;
        public frmUserChangePassword(int Id)
        {
            _Id = Id;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await userService.GetById<MUser>(_Id);
                UserUpsertRequest request = null;
                if (txtOldPassword.Text == APIService.Password)
                {
                    request = new UserUpsertRequest
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Username = user.Username,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        Password = txtNewPassword.Text,
                        PasswordConfirmation = txtNewPasswordConfirmation.Text
                    };
                }
                else
                {
                    MessageBox.Show("Old password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNewPassword.Text != txtNewPasswordConfirmation.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await userService.Update<MUser>(_Id, request);

                MessageBox.Show("Password succesfully changed, please reopen the application and relogin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Ups, something went wrong!");
            }
        }
    }
}
