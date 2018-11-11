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

namespace Agency.Clients
{
    public partial class RacunZaKlijentaForm : Form
    {

        private int klijentId;

        public RacunZaKlijentaForm()
        {
            InitializeComponent();
        }

        private void RacunZaKlijentaForm_Load(object sender, EventArgs e)
        {
            nazivKlijentaList.DataSource = DAKlijenti.KlijentiSelectNOArgs();
            nazivKlijentaList.DisplayMember = "Naziv";
            nazivKlijentaList.ValueMember = "KlijentId";
        }

        private void nazivKlijentaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            rezervacijeDatagrid.DataSource = nazivKlijentaList.SelectedIndex == 0 ? 
                null : DAKlijenti.RezervacijeSelectByKlijentId(Convert.ToInt32(nazivKlijentaList.SelectedValue));
            if(nazivKlijentaList.SelectedIndex != 0)
            klijentId = Convert.ToInt32(nazivKlijentaList.SelectedValue);

        }

        private void osnovniRacunPrikaz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rezervacijeDatagrid.SelectedRows[0].Cells[0].Value) != 0)  
            {
                var racun = new RacunZaKlijentaMaliPrikazForm(Convert.ToInt32(rezervacijeDatagrid.SelectedRows[0].Cells[0].Value));
                racun.Show();
            }
            else
            {
                MessageBox.Show(Global.GetString("select_miss"), "Nedozvoljena operacija", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void detaljniRacunPrikaz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rezervacijeDatagrid.SelectedRows[0].Cells[0].Value) != 0)
            {
                var racun = new RacunZaKlijentaVelikiPrikazForm(klijentId, Convert.ToInt32(rezervacijeDatagrid.SelectedRows[0].Cells[0].Value));
                racun.Show();
            }
        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
           