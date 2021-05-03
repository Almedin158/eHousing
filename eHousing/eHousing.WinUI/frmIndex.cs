using eHousing.Model;
using eHousing.WinUI.Forms.City;
using eHousing.WinUI.Forms.Estate;
using eHousing.WinUI.Forms.EstateType;
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
    public partial class frmIndex : Form
    {
        private readonly APIService userService = new APIService("User");
        private int childFormNumber = 0;
        private MUser _user;
        public frmIndex(MUser user)
        {
            _user = user;
            SignedInUser.User = _user;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserGet frm = new frmUserGet(_user);
            frm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAdd frm = new frmUserAdd();
            frm.Show();
        }

        private async void frmIndex_Load(object sender, EventArgs e)
        {
            var newUser = await userService.GetById<MUser>(_user.UserId);
            var logedInUser = newUser.UserRoles.Select(i => i.Role.Name).FirstOrDefault();
            if (logedInUser == "User")
            {
                usersToolStripMenuItem.Visible = false;
                getToolStripMenuItem.Visible = false;
                addToolStripMenuItem.Visible = false;
            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(_user,_user.UserId);
            frm.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCityAdd frm = new frmCityAdd();
            frm.Show();
        }

        private void getToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCityGet frm = new frmCityGet();
            frm.Show();
        }

        private void addEstateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateTypeAdd frm = new frmEstateTypeAdd();
            frm.Show();
        }

        private void getEstateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateTypeGet frm = new frmEstateTypeGet();
            frm.Show();
        }

        private void estateAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateAdd frm = new frmEstateAdd(_user);
            frm.Show();
        }

        private void getEstateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateGet frm = new frmEstateGet();
            frm.Show();
        }
    }
}
