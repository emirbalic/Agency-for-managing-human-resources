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
    public partial class RacunZaKlijentaVelikiPrikazForm : Form
    {
        private int klijentId, rezervacijaId;

        public RacunZaKlijentaVelikiPrikazForm( int k, int r)
        {
            InitializeComponent();
            klijentId = k;
            rezervacijaId = r;
            //MessageBox.Show("vrijednosti su " + r + " " + k);
        }

        private void RacunZaKlijentaVelikiPrikazForm_Load(object sender, EventArgs e)
        {
            esp_RacunSelectByClientId_Result racun = DAKlijenti.RacunSelectByClientId(klijentId, rezervacijaId);
            if (racun != null)
            {
                nazivFirmeText.Text = racun.Naziv_Firme;
                tipAktivnostiText.Text = racun.Tip_aktivnosti;
                imeIPrezimeRadnikaText.Text = racun.Ime_i_prezime_radnika;
                strukaText.Text = racun.Struka;
                strucnaSpremaText.Text = racun.Stručna_sprema;
                datumPocetkaText.Text = Convert.ToString(racun.DatumPocetka);
                datumZavršetka.Text = Convert.ToString(racun.DatumZavrsetka);
                datumRezervacijeText.Text = Convert.ToString(racun.DatumRezervacije);
                brojSatiText.Text = Convert.ToString(racun.BrojRadnihSati);
                datumIspostaveRacunaText.Text = Convert.ToString(racun.DatumIspostaveRacuna);
                cijenaPoSatuText.Text = Convert.ToString(racun.CijenaPoSatu);

                ukupnoText.Text = Convert.ToString(racun.Ukupan_iznos_računa);

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
