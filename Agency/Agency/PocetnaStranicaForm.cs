using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency.Admin;
using Agency.Clients;
using Agency.Reports;
using Agency.Reservation;
using Agency.Users;
using Agency.Workers;
using Agency_Servis.Data;

namespace Agency
{
    public partial class PocetnaStranicaForm : Form
    {
        public PocetnaStranicaForm()
        {
            InitializeComponent();

            bool check = false;
            List<Uloge> uloge = DAAdministracija.UlogeSelectByKorisnikId(Global.prijavljeniKorisnik.KorisnikId);

            foreach (Uloge u in uloge)
            {
                if (u.UlogaId == 1)
                {
                    check = true;
                    break;
                }                
            }
            if (check == false)
            {
                administracijaToolStripMenuItem.Enabled = false;
                noviKorisnikToolStripMenuItem.Enabled = false;
                pretragaKorisnikaToolStripMenuItem.Enabled = false;
            }

        }

        private void noviKorisnikToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Users.NoviKorisnikForm noviKorisnikForm = new NoviKorisnikForm();
            noviKorisnikForm.Show();
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.PretragaAdministracijaKorisnikaForm pretragaForm = new Users.PretragaAdministracijaKorisnikaForm();
            pretragaForm.Show();
        }

        private void PocetnaStranicaForm_Load(object sender, EventArgs e)
        {
            korisnikLabel.Text = "Korisnik: " + Global.prijavljeniKorisnik.Osobe.Ime + " "
                     + Global.prijavljeniKorisnik.Osobe.Prezime + ", korisnik ID: " + Global.prijavljeniKorisnik.KorisnikId;
        }

        private void novaUlogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.UnosUlogaForm unos = new UnosUlogaForm();
            unos.Show();
        }

        private void novaStrukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.UnosStrukeForm unos = new UnosStrukeForm();
            unos.Show();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.UnosSkolskeSpremeForm unos = new UnosSkolskeSpremeForm();
            unos.Show();
        }

        private void noviKlijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.NoviKlijentForm noviKlijent = new NoviKlijentForm();
            noviKlijent.Show();
        }



        private void noviRadnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.NoviRadnikForm noviRadnik = new NoviRadnikForm();
            noviRadnik.Show();
        }

        private void upravljanjePodacimaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Workers.PretragaAdministracijaRadnika pretraga = new PretragaAdministracijaRadnika();
            pretraga.Show();

            

        }

        private void prikazRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation.PregledRezervacijaZaRačun pregled = new PregledRezervacijaZaRačun();
            pregled.Show();
        }

        private void upravljanjePodacimaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clients.PretragaAdministracijaKlijenataForm pretragaAdministracija = new PretragaAdministracijaKlijenataForm();
            pretragaAdministracija.Show();
        }

        private void napraviRacunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.RacunInsertAndInfoForm racunInsertAndInfo = new RacunInsertAndInfoForm();
            racunInsertAndInfo.Show();
        }

        private void ispostaviRacunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients.RacunZaKlijentaForm racun = new RacunZaKlijentaForm();
            racun.Show();
        }

        private void noviTipAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.UnosTipaAktivnostiForm unos = new UnosTipaAktivnostiForm();
            unos.Show();
        }

        private void novaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Struka> struka = DARadnici.StrukeSelectAll();
            Reservation.PretragaPoStruciForm pretragaPoStruci = new PretragaPoStruciForm(struka);
            pretragaPoStruci.Show();
        }

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation.PregledRezervacijaForm pregledRezervacija = new PregledRezervacijaForm();
            pregledRezervacija.Show();
        }



        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin.PregledStrukaForm pregled = new PregledStrukaForm();
            pregled.Show();
        }

        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Admin.PregledStrucneSpremeForm pregled = new PregledStrucneSpremeForm();
            pregled.Show();
        }

        private void pregledToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Admin.PregledTipAktivnostiForm pregled = new PregledTipAktivnostiForm();
            pregled.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.PregledUlogaForm pregled = new PregledUlogaForm();
            pregled.Show();
        }

        private void racuniZaRadnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.RadnikRacunForm racun = new RadnikRacunForm();
            racun.WindowState = FormWindowState.Maximized;
            racun.MdiParent = this;
            racun.Show();
        }

        private void racuniZaklijenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.KlijentRacunForm racun = new KlijentRacunForm();
            racun.WindowState = FormWindowState.Maximized;
            racun.MdiParent = this;
            racun.Show();
        }




        


















    }
}


