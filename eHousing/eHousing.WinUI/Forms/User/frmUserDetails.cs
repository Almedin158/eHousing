using eHousing.Model;
using eHousing.Model.Request;
using eHousing.WinUI.Helper;
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
    public partial class frmUserDetails : Form
    {
        private MUser _user;
        private readonly APIService userService = new APIService("User");
        private readonly APIService roleService = new APIService("Role");
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        private readonly int _Id;
        public frmUserDetails(MUser user,int Id)
        {
            _user = user;
            SignedInUser.User = _user;
            _Id = Id;
            InitializeComponent();
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            var user = await userService.GetById<MUser>(_Id);
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtUsername.Text = user.Username;

            var roles = await roleService.Get<List<MRole>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "RoleId";
            clbRoles.DisplayMember = "Name";

            var newUser = await userService.GetById<MUser>(_user.UserId);
            var admin = newUser.UserRoles.Select(i => i.Role.Name).FirstOrDefault();
            if (admin == "Admin")
            {
                btnChangePassword.Visible = false;
            }
            else
            {
                label6.Visible = false;
                clbRoles.Visible = false;
                btnDelete.Visible = false;
            }

            var rolesList = clbRoles.Items.Cast<MRole>().Select(i => i.RoleId).ToList();
            foreach (var userRole in user.UserRoles)
            {
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (rolesList[i] == userRole.RoleId)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var user = await userService.GetById<MUser>(_Id);
            if (ValidateChildren())
            {
                var roleList = clbRoles.CheckedItems.Cast<MRole>().Select(x => x.RoleId).ToList();
                List<int> uncheckedRoles = new List<int>();
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (!clbRoles.GetItemChecked(i))
                    {
                        int RoleID = clbRoles.Items.Cast<MRole>().ToList()[i].RoleId;
                        uncheckedRoles.Add(RoleID);
                    }
                }

                var request = new UserUpsertRequest
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Roles = roleList,
                    RolesToDelete = uncheckedRoles
                };

                await userService.Update<MUser>(_Id, request);
                MessageBox.Show("User has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await userService.Delete<dynamic>(_Id);
                MessageBox.Show("User succesfully deleted.");
            }
            this.Close();
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmUserChangePassword frm = new frmUserChangePassword(_Id);
            frm.Show();
        }
    }
}
