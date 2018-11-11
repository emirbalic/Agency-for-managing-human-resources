using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency_Servis.Data;
using Microsoft.Reporting.WinForms;

namespace Agency.Reports
{
    public partial class KlijentRacunForm : Form
    {
        public KlijentRacunForm()
        {
            InitializeComponent();
        }

        private void KlijentRacunForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Agency.Reports.KlijentRacunReport.rdlc";
            klijentList.DataSource = DAKlijenti.KlijentiSelectNOArgs();
            klijentList.DisplayMember = "Naziv";
            klijentList.ValueMember = "KlijentId";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int klijentId = Convert.ToInt32(klijentList.SelectedValue);
            List<esp_xrp_Racun_SelectByClientId_Result> ds = DAIzvjestaji.RacunZaReport(klijentId);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
