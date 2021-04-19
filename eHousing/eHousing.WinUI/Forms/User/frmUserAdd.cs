using eHousing.Model.Model;
using eHousing.Model.Model.Request;
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
    public partial class frmUserAdd : Form
    {
        private readonly APIService userService = new APIService("User");
        private readonly APIService roleService = new APIService("Role");
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public frmUserAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var roleList = clbRoles.CheckedItems.Cast<MRole>().Select(i => i.RoleId).ToList();

            var request = new UserUpsertRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Username = txtUsername.Text,
                Password=txtPassword.Text,
                PasswordConfirmation=txtPasswordConfirmation.Text,
                Roles=roleList
            };
            await userService.Insert<MUser>(request);
            MessageBox.Show("User added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void frmUserAdd_Load(object sender, EventArgs e)
        {
            var roles = await roleService.Get<List<MRole>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "RoleId";
            clbRoles.DisplayMember = "Name";
        }
        #region
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtLastName, null);
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
                bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
                if (isEmailValid == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Enter email in a valid format!");
                }
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhoneNumber.Text.ToString();
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length < 9 || txtPhoneNumber.Text.Length > 9)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhoneNumber, "Phone number needs to contain 9 digits!");
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
                if (IsDigitsOnly(phone) == false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPhoneNumber, "You can't use letters!");
                }
                else
                {
                    errorProvider1.SetError(txtPhoneNumber, null);
                }
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (hasNumber.IsMatch(txtPassword.Text) && hasUpperChar.IsMatch(txtPassword.Text) && hasMinimum8Chars.IsMatch(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, null);
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "Password should have number, uppercase, lowercase and minimum 8 characters!");
                    e.Cancel = true;

                }
            }
        }
        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text))
            {
                errorProvider1.SetError(txtPasswordConfirmation, Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtPassword.Text == txtPasswordConfirmation.Text)
                {
                    errorProvider1.SetError(txtPasswordConfirmation, null);
                }
                else
                {
                    errorProvider1.SetError(txtPasswordConfirmation, "Passwords do not match!");
                    e.Cancel = true;
                }
            }
        }
        private void clbRoles_Validating(object sender, CancelEventArgs e)
        {

            var roleList = clbRoles.CheckedItems.Cast<MRole>().Select(x => x.RoleId).ToList();
            if (roleList.Count() == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(clbRoles, "You must choose at least one role!");
            }
            else
            {
                errorProvider1.SetError(clbRoles, null);
            }

        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "This field need to contain at least 3 letters");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        #endregion
    }
}
