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

namespace Agency.Reservation
{
    public partial class KalendarDostupnostiRadnikaForm : Form
    {
        private Radnici radnik = new Radnici();

        public KalendarDostupnostiRadnikaForm(Radnici r)
        {
            InitializeComponent();
            if (r != null)
            {
                radnik = r;
                UcitajPodatke();
            }
        }
                private void UcitajPodatke()
                {

                    imeText.Text = radnik.Osobe.Ime;
                    prezimeText.Text = radnik.Osobe.Prezime;
                    rezervacijeGrid.DataSource = DARadnici.StavkeRezervacijeSelectById(radnik.RadnikId);
                    rezervacijeGrid.Columns[0].Visible = false;
                    rezervacijeGrid.Columns[1].Visible = false;
                    rezervacijeGrid.Columns[7].Visible = false;
                    rezervacijeGrid.Columns[8].Visible = false;
                }

                private void potvrdiSubmit_Click(object sender, EventArgs e)
                {
                    if (izadjiRadio.Checked)
                    {
                        this.Close();

                    }
                    if (ponoviPretraguRadio.Checked)
                    {
                        this.Close();
                        PretragaPoStruciForm pretraga = new PretragaPoStruciForm(DARadnici.StrukeSelectAll());
                        pretraga.Show();
                    }
                        

                    if (rezervirajRadio.Checked)
                    {
                        NovaRezervacijaForm novaRezervacija = new NovaRezervacijaForm(radnik);
                        novaRezervacija.Show();

                        this.Close();
                    }
                }

                private void zatvoriSubmit_Click(object sender, EventArgs e)
                {
                    Close();
                }
  }
}
