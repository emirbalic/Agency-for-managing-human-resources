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
    public partial class PretragaAdministracijaKorisnikaForm : Form
    {
        private Korisnici korisnik;
        private Osobe osoba;
        public PretragaAdministracijaKorisnikaForm()
        {
            InitializeComponent();
        }

        private void PretragaAdministracijaKorisnikaForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            korisniciGrid.DataSource = DAKorisnici.SelectByName(imeIPrezimeInput.Text);
            korisniciGrid.Columns[0].Visible = false;
            korisniciGrid.Columns[1].Visible = false;
            korisniciGrid.ClearSelection();
        }

        private void imeIPrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void deaktivirajSubmit_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                if ((bool)korisniciGrid.SelectedRows[0].Cells[6].Value && korisnik.KorisnikId != Global.prijavljeniKorisnik.KorisnikId)
                {
                    DAKorisnici.UpdateStatus(korisnik.KorisnikId, false);
                    BindGrid();
                    MessageBox.Show(Global.GetString("user_deact") + korisnik.Osobe.Prezime + " " + korisnik.Osobe.Ime, "Deaktivacija");
                }
                else
                {
                    MessageBox.Show(Global.GetString("deact_err"), "Nedozvoljena operacija", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
            }
            else
            {
                GetValue();
            }
        }

        private void korisniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int korisnikId = Convert.ToInt32(korisniciGrid.SelectedRows[0].Cells[1].Value);
            korisnik = DAKorisnici.SelectById(korisnikId);
            osoba = DAKorisnici.SelectOsobaByKorisnikId(korisnikId);
        }

        private void aktivirajSubmit_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                DAKorisnici.UpdateStatus(korisnik.KorisnikId, true);
                BindGrid();
                MessageBox.Show(Global.GetString("user_act") + korisnik.Osobe.Prezime + " " + korisnik.Osobe.Ime, "Ponovna aktivacija");
            }
            else
            {
                GetValue();
            }
        }

        private void licniMenu_Click(object sender, EventArgs e)
        {
            if (osoba != null)
            {
                IzmjenaLicnihPodatakaForm izmjenaLicnih = new IzmjenaLicnihPodatakaForm(osoba);
                izmjenaLicnih.ShowDialog();
                BindGrid();
            }
            else
            {
                GetValue();
            }
        }

        private static void GetValue()
        {
            MessageBox.Show(Global.GetString("select_miss"), "Upravljanje aplikacijom", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void statusniMenu_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                IzmjenaStatusnihPodatakaForm izmjenaStatusnih = new IzmjenaStatusnihPodatakaForm(korisnik);
                izmjenaStatusnih.ShowDialog();
                BindGrid();
            }
            else
            {
                GetValue();
            }
        }

        private void userInfoSubmit_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                InfoOKorisnikuForm info = new InfoOKorisnikuForm(korisnik);
                info.Show();
                BindGrid();
            }
            else
            {
                GetValue();
            }
        }

        private void closeSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
