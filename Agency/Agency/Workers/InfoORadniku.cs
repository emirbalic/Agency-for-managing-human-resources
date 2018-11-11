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

namespace Agency.Workers
{
    public partial class InfoORadniku : Form
    {
        private esp_RadniciOsobeSelectAll_Result radnik;
        public InfoORadniku(esp_RadniciOsobeSelectAll_Result r)
        {
            InitializeComponent();
            radnik = r;
        }

        private void InfoORadniku_Load(object sender, EventArgs e)
        {
            imeLabel.Text = radnik.Ime;
            prezimeLabel.Text = radnik.Prezime;
            emailLabel.Text = radnik.Email;
            jmbgLebel.Text = radnik.JMBG;
            telefonLabel.Text = radnik.Telefon;
            statusLabel.Text = Convert.ToString(radnik.Status);
            strucnaSpremaLabel.Text = radnik.Stručna_sprema;
            strukaLabel.Text = radnik.Struka;
            datumLabel.Text = Convert.ToString(radnik.DatumPrveRegistracije);

        }
    }
}
