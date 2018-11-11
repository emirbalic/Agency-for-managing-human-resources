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
namespace Agency.Reservation
{
    public partial class NovaRezervacijaForm : Form
    {
        Radnici radnik = new Radnici();

        Rezervacija rezervacija = new Rezervacija();
        StavkeRezervacije stavke = new StavkeRezervacije();



        public NovaRezervacijaForm(Radnici r)
        {
            InitializeComponent();
            if (r != null)
            {
                radnik = r;
                UcitajPodatke();
                AutoValidate = AutoValidate.Disable;
            }

        }
        private void UcitajPodatke()
        {
            imeText.Text = radnik.Osobe.Ime;
            prezimeText.Text = radnik.Osobe.Prezime;
            nazivFirmeList.DataSource = DAKlijenti.KlijentiSelectNOArgs();
            nazivFirmeList.DisplayMember = "Naziv";
            nazivFirmeList.ValueMember = "KlijentId";
        }

        private void rezervirajSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                rezervacija.KlijentId = Convert.ToInt32(nazivFirmeList.SelectedValue);
                stavke.RadnikId = radnik.RadnikId;
                stavke.DatumRezervacije = DateTime.Now;
                stavke.DatumPocetka = pocetakDateTime.Value;
                stavke.DatumZavrsetka = krajDateTime.Value;
                TimeSpan brojDana = Convert.ToDateTime(stavke.DatumZavrsetka) - Convert.ToDateTime(stavke.DatumPocetka);
                var dani = brojDana.Days;
                stavke.BrojRadnihSati = dani * 8;
                brojRadnihSati.Text = Convert.ToString(stavke.BrojRadnihSati);

                if (stavke.DatumPocetka <= DateTime.Now)
                {
                    MessageBox.Show(Global.GetString("reserve_late"), "Neuspješna rezervacija", MessageBoxButtons.OK);
                    Close();
                    PretragaPoStruciForm pretraga = new PretragaPoStruciForm(DARadnici.StrukeSelectAll());
                    pretraga.Show();
                    return;
                }
                if (stavke.DatumPocetka > stavke.DatumZavrsetka)
                {
                    MessageBox.Show(Global.GetString("reserve_err_reverse"), "Neuspješna rezervacija", MessageBoxButtons.OK);
                    pocetakDateTime.ResetText();
                    krajDateTime.ResetText();
                    brojRadnihSati.Text = "";
                    return;

                }
                List<StavkeRezervacije> listaStavki = DARadnici.StavkeRezervacijeSelectById(radnik.RadnikId);

                foreach (var sR in listaStavki)
                {
                    if ((stavke.DatumPocetka > sR.DatumPocetka && stavke.DatumPocetka < sR.DatumZavrsetka)
                        || (stavke.DatumPocetka < sR.DatumPocetka && stavke.DatumZavrsetka > sR.DatumPocetka)
                        || (stavke.DatumPocetka < sR.DatumZavrsetka && stavke.DatumZavrsetka > sR.DatumPocetka))
                    {
                        MessageBox.Show(Global.GetString("reserve_err"), "Neuspješna rezervacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        PretragaPoStruciForm pretraga = new PretragaPoStruciForm(DARadnici.StrukeSelectAll());
                        pretraga.Show();
                        return;
                    }

                }
                DAKlijenti.RezervacijaCreate(rezervacija, stavke);

                MessageBox.Show(Global.GetString("reserve_succ"), "Nova rezervacija", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }             
        }




        private void nazadSubmit_Click(object sender, EventArgs e)
        {
            KalendarDostupnostiRadnikaForm kalendar = new KalendarDostupnostiRadnikaForm(radnik);
            Close();
            kalendar.Show();
        }

        private void nazivFirmeList_Validating(object sender, CancelEventArgs e)
        {
            //if (!(nazivFirmeList.SelectedIndex > -1))
                if (string.IsNullOrEmpty(nazivFirmeList.Text))
                    e.Cancel = true;

  
        }


    }
}
