using eHousing.Model;
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
    public partial class frmEstateRentDetails : Form
    {
        private readonly APIService estateService = new APIService("Estate");
        public frmEstateRentDetails()
        {
            InitializeComponent();
        }

        private async void frmEstateRentDetails_Load(object sender, EventArgs e)
        {
            var estates = await estateService.Get<List<MEstate>>(null);
            cbEstates.DataSource = estates;
            cbEstates.ValueMember = "EstateId";
            cbEstates.DisplayMember = "EstateName";
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (EstateRentDetailsEntities db = new EstateRentDetailsEntities())
            {
                var source = db.EstateRentDetails(Convert.ToInt32(cbEstates.SelectedValue)).ToList();

                ReportDataSource ds = new ReportDataSource("DataSet1", source);

                ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("EstateId", Convert.ToInt32(cbEstates.SelectedValue).ToString())
            };
                reportViewer1.LocalReport.SetParameters(reportParameters);
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
