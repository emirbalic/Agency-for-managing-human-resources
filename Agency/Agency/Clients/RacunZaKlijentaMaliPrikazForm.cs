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
    public partial class RacunZaKlijentaMaliPrikazForm : Form
    {
        //private int klijentId;    int k,             klijentId = k;   k != 0 klijentId, 
        private int rezervacijaId;
        public RacunZaKlijentaMaliPrikazForm(int r)
        {
            InitializeComponent();
            if (r != 0)
            {
    
                rezervacijaId = r;
            }

            //MessageBox.Show("ovo su vrijednosti: " + a + " " + b);
            
        }

        private void RacunZaKlijentaPrikazForm_Load(object sender, EventArgs e)
        {
            esp_RacunSelectByRezervacijaId_Result racun = DAKlijenti.RacunSelectByRezervacijaId(rezervacijaId);
            if (racun != null)
            {
                
                klijentText.Text = racun.Klijent;
                iznosText.Text = Convert.ToString(racun.Iznos);
                datumText.Text = Convert.ToString(racun.DatumIspostaveRacuna);
                
            }

            else
            {
                MessageBox.Show("racun još nije napravljen");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
