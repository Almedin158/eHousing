using eHousing.WinUI.DataSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHousing.WinUI.ReportForms
{
    public partial class frmTop3EstatesWithMostRents : Form
    {
        public frmTop3EstatesWithMostRents()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            using (Top3EstatesWithMostRentsEntities db = new Top3EstatesWithMostRentsEntities())
            {
                Top3EstatesWithMostRents_ResultBindingSource.DataSource = db.Top3EstatesWithMostRents().ToList();
                reportViewer1.RefreshReport();
            };
        }
    }
}
