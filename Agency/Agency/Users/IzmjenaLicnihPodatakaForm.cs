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

namespace Agency.Users
{
    public partial class IzmjenaLicnihPodatakaForm : Form
    {
        private Osobe osoba;

        public IzmjenaLicnihPodatakaForm(Osobe o)
        {
            InitializeComponent();
                            osoba = o;
            UcitajPodatkeOsobe();
        }
        void UcitajPodatkeOsobe()
        {
            imeInput.Text = osoba.Ime;
            prezimeInput.Text = osoba.Prezime;
            emailInput.Text = osoba.Email;
            telefonInput.Text = osoba.Telefon;
            adresaInput.Text = osoba.Adrese.UlicaIBroj;
            mjestaList.DataSource = DAKorisnici.MjestaSelectAll();
            mjestaList.DisplayMember = "Naziv";
            mjestaList.ValueMember = "MjestoId";

         
        }

        private void dodajSubmit_Click(object sender, EventArgs e)
        {
            Osobe osobeIzmjene = new Osobe();
            if (osoba != null)
            {
                osobeIzmjene.OsobaId = osoba.OsobaId;

                osobeIzmjene.Ime = imeInput.Text;
                osobeIzmjene.Prezime = prezimeInput.Text.Trim();
                osobeIzmjene.Email = emailInput.Text;
                osobeIzmjene.Telefon = telefonInput.Text;

                string ulicaIBroj = adresaInput.Text;
                int mjestoId = Convert.ToInt32(mjestaList.SelectedValue);

                try
                {
                    DAKorisnici.UpdateLicnihPodataka(osobeIzmjene, ulicaIBroj, mjestoId);
                    MessageBox.Show(Global.GetString("user_change_succ") + " " + osobeIzmjene.Ime + " " + osobeIzmjene.Prezime,
                        "Izmjena podataka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(Global.GetString(ex.Message));
                }
                
               
                this.Close();
            }
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odustaniSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                odustaniSubmit_Click(sender, e);

        }

        private void dodajSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dodajSubmit_Click(sender, e);

        }
    }
}
