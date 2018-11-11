using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agency_Servis.Data;

namespace Agency_Web.Reservation
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected esp_RadniciOsobeSelectById_ToUpdate_Result radnik;

        private int radnikId;
        private int klijentId;

        protected Klijenti klijent = new Klijenti();

        protected List<esp_RadniciOsobeSelectById_ToUpdate_Result> radnici = new List<esp_RadniciOsobeSelectById_ToUpdate_Result>();

        protected  List<Klijenti> klijenti = new List<Klijenti>();

        public StavkeRezervacije rezervacijaSession
        {
            get { return (StavkeRezervacije)Session["rezervacijaSession"]; }
            set { Session["rezervacijaSession"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                BindClients();
            }
           
        }

        private void BindClients()
        {
            string userName = User.Identity.Name;
            klijent = DAKlijenti.webSelectByKorisnickoIme_NoPassRequired(userName);           
            klijentId = klijent.KlijentId;    //
            klijenti.Add(klijent);  // zbog dataGrida, mada nije moralo tako ali hajde de
            klijentGrid.DataSource = klijenti;
            klijentGrid.DataBind();
        }

        private void BindGrid()
        {
            if (rezervacijaSession != null)
            {


                radnikId = Convert.ToInt32(rezervacijaSession.RadnikId);
                radnik = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
                List<esp_RadniciOsobeSelectById_ToUpdate_Result> tempHeader = new List<esp_RadniciOsobeSelectById_ToUpdate_Result>();
                esp_RadniciOsobeSelectById_ToUpdate_Result tempItem = radnik;
                tempHeader.Add(tempItem);
                radnikGrid.DataSource = tempHeader;
                radnikGrid.DataBind();

                

                List<StavkeRezervacije> temp = new List<StavkeRezervacije>();
                StavkeRezervacije item = rezervacijaSession;//temp[0];//
                temp.Add(item);
                stavkeRezervacijeGrid.DataSource = temp;
                stavkeRezervacijeGrid.DataBind();

                int ukupno = Convert.ToInt32(radnik.CijenaPoSatu);
                int dani = item.BrojRadnihSati;
                iznosLabel.Text = Convert.ToString(ukupno*dani);
            }
        }
        protected void kreirajSubmit_Click(object sender, EventArgs e)
        {
            StavkeRezervacije stavkeRezervacije = new StavkeRezervacije();
            Rezervacija rezervacija = new Rezervacija();
            string userName = User.Identity.Name;
            Klijenti k = new Klijenti();
            k = DAKlijenti.webSelectByKorisnickoIme_NoPassRequired(userName);

            if (rezervacijaSession != null)
            {
                radnikId = Convert.ToInt32(rezervacijaSession.RadnikId);
                stavkeRezervacije.RadnikId = radnikId;

                rezervacija.KlijentId = k.KlijentId;

                stavkeRezervacije.DatumRezervacije = rezervacijaSession.DatumRezervacije;
                stavkeRezervacije.DatumPocetka = rezervacijaSession.DatumPocetka;
                stavkeRezervacije.DatumZavrsetka = rezervacijaSession.DatumZavrsetka;
                stavkeRezervacije.BrojRadnihSati = rezervacijaSession.BrojRadnihSati;

                if (rezervacijaSession.DatumPocetka < DateTime.Now)
                {

                    Regret.Visible = true;
                    HideToo();
                    Hide();
                    return;
                }
                List<StavkeRezervacije> listaStavki = DARadnici.StavkeRezervacijeSelectById(radnikId);
                foreach (var lS in listaStavki)
                {
                    if
                        ((stavkeRezervacije.DatumPocetka > lS.DatumPocetka &&
                          stavkeRezervacije.DatumPocetka < lS.DatumZavrsetka)
                         ||
                         (stavkeRezervacije.DatumPocetka < lS.DatumPocetka &&
                          stavkeRezervacije.DatumZavrsetka > lS.DatumPocetka)
                         ||
                         (stavkeRezervacije.DatumPocetka < lS.DatumZavrsetka &&
                          stavkeRezervacije.DatumZavrsetka > lS.DatumPocetka))
                    {
                        Regret.Visible = true;
                        return;
                    }
                }

                DAKlijenti.RezervacijaCreate(rezervacija, stavkeRezervacije);
                Notification.Visible = true;
                Hide();
                // dodao liniju koda jer ponovljena rezervacija nije radila
                rezervacijaSession = null;
            }
            else
            {
                NoneChosen.Visible = true;
                HideToo();
                Hide();
            }



        }

        private void HideToo()
        {
            racunLabel.Visible = false;
            iznosLabel.Visible = false;
        }

        private void Hide()
        {
            radnikGrid.Visible = false;
            stavkeRezervacijeGrid.Visible = false;
            klijentGrid.Visible = false;
            lblPrikaz.Visible = false;
            lblProvjera.Visible = false;
            lblRadnik.Visible = false;
            lblRezervacija.Visible = false;
            lblRezervirati.Visible = false;
            kreirajSubmit.Visible = false;
            otkazziSubmit.Visible = false;

        }

        protected void otkazziSubmit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Default.aspx");
        }

    }
}

