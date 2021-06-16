using eHousing.Model;
using eHousing.WinUI.Forms.City;
using eHousing.WinUI.Forms.Estate;
using eHousing.WinUI.Forms.EstateType;
using eHousing.WinUI.Forms.User;
using eHousing.WinUI.Helper;
using eHousing.WinUI.ReportForms;
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
            frmUserGet frm = new frmUserGet(_user)
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAdd frm = new frmUserAdd()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
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
                cityToolStripMenuItem.Visible = false;
                estateTypeToolStripMenuItem.Visible = false;
                getEstateToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(_user, _user.UserId)
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCityAdd frm = new frmCityAdd()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void getToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCityGet frm = new frmCityGet()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void addEstateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateTypeAdd frm = new frmEstateTypeAdd()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void getEstateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateTypeGet frm = new frmEstateTypeGet()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void estateAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateAdd frm = new frmEstateAdd(_user)
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void getEstateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateGet frm = new frmEstateGet()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void myEstatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyEstates frm = new frmMyEstates(_user.UserId)
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void topThreeEstatesWithMostRentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTop3EstatesWithMostRents frm = new frmTop3EstatesWithMostRents()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void lastFiveEstateRentersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLast5EstateRenters frm = new frmLast5EstateRenters()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void estateDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstateRentDetails frm = new frmEstateRentDetails()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void frmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
