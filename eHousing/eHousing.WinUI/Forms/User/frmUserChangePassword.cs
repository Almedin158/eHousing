using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                errorProvider1.SetError(txtOldPassword, Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (hasNumber.IsMatch(txtOldPassword.Text) && hasUpperChar.IsMatch(txtOldPassword.Text) && hasMinimum8Chars.IsMatch(txtOldPassword.Text))
                {
                    errorProvider1.SetError(txtOldPassword, null);
                }
                else
                {
                    errorProvider1.SetError(txtOldPassword, "Password should have number, uppercase, lowercase and minimum 8 characters!");
                    e.Cancel = true;

                }
            }
        }
        private void txtNewPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            if (string.IsNullOrWhiteSpace(txtNewPasswordConfirmation.Text))
            {
                errorProvider1.SetError(txtNewPasswordConfirmation, Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (hasNumber.IsMatch(txtNewPasswordConfirmation.Text) && hasUpperChar.IsMatch(txtNewPasswordConfirmation.Text) && hasMinimum8Chars.IsMatch(txtNewPasswordConfirmation.Text))
                {
                    errorProvider1.SetError(txtNewPasswordConfirmation, null);
                }
                else
                {
                    errorProvider1.SetError(txtNewPasswordConfirmation, "Password should have number, uppercase, lowercase and minimum 8 characters!");
                    e.Cancel = true;

                }
            }
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (hasNumber.IsMatch(txtNewPassword.Text) && hasUpperChar.IsMatch(txtNewPassword.Text) && hasMinimum8Chars.IsMatch(txtNewPassword.Text))
                {
                    errorProvider1.SetError(txtNewPassword, null);
                }
                else
                {
                    errorProvider1.SetError(txtNewPassword, "Password should have number, uppercase, lowercase and minimum 8 characters!");
                    e.Cancel = true;

                }
            }
        }
    }
}
