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
    public partial class InfoOKorisnikuForm : Form
    {
        private Korisnici korisnik;

        public InfoOKorisnikuForm(Korisnici k)
        {
            InitializeComponent();
            korisnik = k;
            ucitajPodatke();
        }
        private void ucitajPodatke()
        {
            korisnikGroup.Text = korisnik.Osobe.Ime + ' ' + korisnik.Osobe.Prezime;
            imeLabel.Text = korisnik.Osobe.Ime;
            prezimeLabel.Text = korisnik.Osobe.Prezime;
            emailLabel.Text = korisnik.Osobe.Email;
            telefonLabel.Text = korisnik.Osobe.Telefon;
            korisnickoImeLabel.Text = korisnik.KorisnickoIme;
            korisnik.Uloge = DAKorisnici.UlogeSelectAll();
            foreach (Uloge u in korisnik.Uloge)
            {
                ulogeList.Items.Add(u.Naziv);
            }
        }
    }
}
