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
    public partial class IzmjenaLicnihPodatakaForm : Form
    {
        private esp_KlijentiSelectAllByNaziv_Result klijent;
        public IzmjenaLicnihPodatakaForm(esp_KlijentiSelectAllByNaziv_Result k)
        {
            InitializeComponent();
            if (k != null)
                klijent = k;
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            nazivReadOnly.Text = klijent.Klijent;
            telefonInput.Text = klijent.Telefon;
            emailInput.Text = klijent.Email;
            ulicaIBrojInput.Text = klijent.UlicaIBroj;
            mjestaList.DataSource = DAKorisnici.MjestaSelectAll();
            mjestaList.DisplayMember = "Naziv";
            mjestaList.ValueMember = "MjestoId";

        }

        private void snimiSubmit_Click(object sender, EventArgs e)
        {
            // ovo bi moglo i pasti lagano...
            //if (mjestaList.SelectedValue != null)
                int mjestoId = Convert.ToInt32(mjestaList.SelectedValue);                


            string telefon = telefonInput.Text;
            string email = emailInput.Text;
            string ulicaIBroj = ulicaIBrojInput.Text;
            string naziv = klijent.Klijent;

            DAKlijenti.KlijentiUpdateLicnihPodataka(naziv, telefon, email, ulicaIBroj, mjestoId);
            MessageBox.Show(Global.GetString("client_change") + " " + klijent.Klijent, "Promjena podataka",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
