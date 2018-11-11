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
    public partial class IzmjenaOsnovnihPodatakaForm : Form
    {
        private esp_RadniciOsobeSelectById_ToUpdate_Result radnik;
        public IzmjenaOsnovnihPodatakaForm(esp_RadniciOsobeSelectById_ToUpdate_Result r)
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
            imeIPrezimeReadOnly.Text = radnik.Ime + " " + radnik.Prezime;
            emailInput.Text = radnik.Email;
            telefonInput.Text = radnik.Telefon;
            cijenaPoSatuInput.Text = Convert.ToString(radnik.CijenaPoSatu);
            
        }
      
        private void snimiSubmit_Click(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string telefon = telefonInput.Text;
            decimal cijena = Convert.ToDecimal(cijenaPoSatuInput.Text);
            DARadnici.RadniciUpdateOsnovnihPodataka(radnik.OsobaId, radnik.RadnikId, email, telefon, cijena );
            this.Close();
            MessageBox.Show(Global.GetString("worker_change_succ") + radnik.Ime + " " + radnik.Prezime, "Promjena podataka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
