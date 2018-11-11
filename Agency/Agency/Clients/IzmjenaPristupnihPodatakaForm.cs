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
using Agency_Servis.Util;

namespace Agency.Clients
{
    public partial class IzmjenaPristupnihPodatakaForm : Form
    {
        private Klijenti klijent;
        public IzmjenaPristupnihPodatakaForm(esp_KlijentiSelectAllByNaziv_Result k)
        {
            InitializeComponent();
            if (k != null)
            {
                klijent = DAKlijenti.KlijentiSelectToUpdateAccessDataByNaziv(k.Klijent);

            }
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            nazivReadOnly.Text = klijent.Naziv;
            korisnickoImeInput.Text = klijent.KorisnickoIme;
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void snimiSubmit_Click(object sender, EventArgs e)
        {

                if (lozinkaInput.Text != "")
                    {

                        klijent.LozinkaSalt = UIHelper.GenerateSalt();
                        klijent.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, klijent.LozinkaSalt);
                        DAKlijenti.KlijentiResetPass(klijent.Naziv, klijent.LozinkaSalt, klijent.LozinkaHash);
                    }
                    else
                    {
                        MessageBox.Show(Global.GetString("input_pass"), "Obavezan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;

                    }
                    if (korisnickoImeInput.Text != "")
                    {
                        klijent.KorisnickoIme = korisnickoImeInput.Text;
                        DAKlijenti.KlijentiChangeUsername(klijent.Naziv, klijent.KorisnickoIme);
                    }
                    else
                    {
                        MessageBox.Show(Global.GetString("input_req_user"), "Obavezan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                MessageBox.Show(Global.GetString("user_change_acc") + " " + klijent.Naziv, "Promjena pristupnih podataka",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
        }
    }
}
