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
    public partial class RadnikRacunForm : Form
    {
        //public static int radnikId;

        public RadnikRacunForm()
        {
            InitializeComponent();
        }

        private void RadnikRacunForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Agency.Reports.RadnikRacunReport.rdlc";
            radniciList.DataSource = DAIzvjestaji.RadniciOsobeSelectNoArgs();
            radniciList.DisplayMember = "Prezime_i_ime";
            radniciList.ValueMember = "RadnikId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radnikId = Convert.ToInt32(radniciList.SelectedValue);
            List<esp_RadniciRezervacijeByRadnikId_Result> ds = DARadnici.RadniciRezervacijeByRadnikIdSelectToList(radnikId);
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
