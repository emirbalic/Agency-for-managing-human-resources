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
    public partial class InfoOKlijentuForm : Form
    {
        private esp_KlijentiSelectAllByNaziv_Result klijent;
        public InfoOKlijentuForm(esp_KlijentiSelectAllByNaziv_Result k)
        {
            InitializeComponent();
            if (k != null)
                klijent = k;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            nazivLabel.Text = klijent.Klijent;
            telefonLabel.Text = klijent.Telefon;
            emailLabel.Text = klijent.Email;
            tipAktivnostiLabel.Text = klijent.Tip_Aktivnosti;
            adresaLebel.Text = klijent.UlicaIBroj;
            gradLebel.Text = klijent.Mjesto;
            drzavaLebel.Text = klijent.Država;
        }


    }
}
