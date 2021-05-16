using eHousing.WinUI.DataSources;
using Microsoft.Reporting.WinForms;
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
    public partial class frmMyEstateRentDetails : Form
    {
        private int EstateId;
        public frmMyEstateRentDetails(int Id)
        {
            EstateId = Id;
            InitializeComponent();
        }

        private void frmMyEstateRentDetails_Load(object sender, EventArgs e)
        {
            using (EstateRentDetailsEntities db = new EstateRentDetailsEntities())
            {
                var source = db.EstateRentDetails(Convert.ToInt32(EstateId)).ToList();

                ReportDataSource ds = new ReportDataSource("DataSet1", source);

                ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("EstateId", Convert.ToInt32(EstateId).ToString())
            };
                reportViewer1.LocalReport.SetParameters(reportParameters);
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
