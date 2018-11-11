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

namespace Agency.Users
{
    public partial class IzmjenaStatusnihPodatakaForm : Form
    {
        private Korisnici korisnik { get; set; }
        public IzmjenaStatusnihPodatakaForm(Korisnici k)
        {
            InitializeComponent();
            if (k != null)
                korisnik = k;
            UcitajPodatke();
        }
        void UcitajPodatke()
        {
            // za upis statusa u formu bez da idem na bazu, provjeriti zašto ne radi...
            //bool check = (bool)DAKorisnici.SelectById(korisnik.KorisnikId).StatusNaSistemu;
            //statusCheckBox.Checked = check;

            korisnickoImeInput.Text = korisnik.KorisnickoIme;
            statusCheckBox.Checked = (bool)korisnik.StatusNaSistemu;
            ulogeList.DataSource = DAKorisnici.UlogeSelectAll();
            ulogeList.DisplayMember = "Naziv";
            ulogeList.ClearSelected();

            korisnik.Uloge = DAKorisnici.SelectUlogeByKorisnik(korisnik.KorisnikId);

            for (int i = 0; i < ulogeList.Items.Count; i++)
            {
                if (korisnik.Uloge.Contains(ulogeList.Items[i]))
                    ulogeList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void sacuvajSubmit_Click(object sender, EventArgs e)
        {
            if (lozinkaInput.Text != "")
            {
                korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                korisnik.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, korisnik.LozinkaSalt);
                DAKorisnici.ResetPassword(korisnik);
            }
            DAKorisnici.UlogeUpdate(korisnik.KorisnikId, ulogeList.CheckedItems.Cast<Uloge>().ToList());

            if (korisnik.KorisnikId == Global.prijavljeniKorisnik.KorisnikId && !statusCheckBox.Checked)
            {
                MessageBox.Show(Global.GetString("deact_err"), "Nedozvoljena operacija", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                statusCheckBox.Checked = true;
                return;

            }

            if (korisnik.StatusNaSistemu != statusCheckBox.Checked)
                DAKorisnici.UpdateStatus(korisnik.KorisnikId, statusCheckBox.Checked);

            MessageBox.Show(Global.GetString("user_change_acc") + " " + korisnik.Osobe.Ime + " " + korisnik.Osobe.Prezime, "Promjena pristupnih podataka",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
