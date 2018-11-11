using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agency_Servis.Data;
using Agency_Servis.Util;


namespace Agency_Web.Reservation
{
    public partial class Calendar : System.Web.UI.Page
    {
        

        //L
        //private static int radnikId; //= 0
        
        int radnikId
        {
            set { ViewState["radnikId"] = value; }
            get { return (int)ViewState["radnikId"]; }
        }
        
        //L
        //protected esp_RadniciOsobeSelectById_ToUpdate_Result radnik = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
        protected esp_RadniciOsobeSelectById_ToUpdate_Result radnik;
        
        //L
        //protected List<StavkeRezervacije> stavke = DARadnici.StavkeRezervacijeSelectById(radnikId);
        protected List<StavkeRezervacije> stavke;


        protected List<Radnici> Radnici= new List<Radnici>(); 


        protected List<esp_RadniciOsobeSelectById_ToUpdate_Result> Preporuka = new List<esp_RadniciOsobeSelectById_ToUpdate_Result>();//  //Radnici

        private DateTime firstDate;
        private DateTime lastDate;

        
        private DateTime datumPocetka;
        private DateTime datumZavrsetka;

        StavkeRezervacije rezervacijaSession
        {
            set { Session["rezervacijaSession"] = value; }
            get { return (StavkeRezervacije) Session["rezervacijaSession"]; }
            
        }

       

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //L
                //radnikId = Convert.ToInt32(Request.QueryString["RadnikId"]);

                //L
                radnikId = Convert.ToInt32(Request.QueryString["RadnikId"]);
                radnik = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
                stavke = DARadnici.StavkeRezervacijeSelectById(radnikId);
                
                Recommend();
                BindGrid();
            }
            else
            {

            }
        }

        private void Recommend()
        {
            
            Radnici = Recommendation.GetSlicneRadnike(radnikId).ToList();
            foreach (var r in Radnici)
            {
                Preporuka.Add(DARadnici.RadniciOsobeSelectByIdToUpdate(r.RadnikId));
            }


            //test

            //esp_RadniciOsobeSelectById_ToUpdate_Result r = new esp_RadniciOsobeSelectById_ToUpdate_Result();
            //r.RadnikId = 1;
            //r.OsobaId = 1;
            //r.Ime = "Emir";
            //r.Prezime = "Balić";
            //r.Email = "neki@mail.ba";
            //r.Telefon = "000000";
            //r.CijenaPoSatu = 123;
            //r.Status = true;
            //Preporuka.Insert(0, r);

            preporukaGrid.DataBind();
        }

        private void BindGrid()
        {
            // **********nisam siguran šta ova radio, provjeriću**********************
            List<esp_RadniciOsobeSelectById_ToUpdate_Result> temp = new List<esp_RadniciOsobeSelectById_ToUpdate_Result>();
            esp_RadniciOsobeSelectById_ToUpdate_Result member = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
            temp.Add(member);
            
            FillInfo();
        }

        private void FillInfo()
        {
            radnikId = Convert.ToInt32(Request.QueryString["RadnikId"]);
            radnik = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
            List<esp_RadniciOsobeSelectById_ToUpdate_Result> tempHeader = new List<esp_RadniciOsobeSelectById_ToUpdate_Result>();
            esp_RadniciOsobeSelectById_ToUpdate_Result tempItem = radnik;
            tempHeader.Add(tempItem);
            radnikGrid.DataSource = tempHeader;
            radnikGrid.DataBind();
        }

        protected void kalendarDostupnosti_DayRender(object sender, DayRenderEventArgs e)
        {
            if (stavke != null)
                FillCalendar(e);
            else
            {

                radnikId = Convert.ToInt32(Request.QueryString["RadnikId"]);
                stavke = DARadnici.StavkeRezervacijeSelectById(radnikId);
                FillCalendar(e);
            }

        }

        private void FillCalendar(DayRenderEventArgs e)
        {
            foreach (var item in stavke)
            {
                firstDate = Convert.ToDateTime(item.DatumPocetka);
                lastDate = Convert.ToDateTime(item.DatumZavrsetka);
                if (e.Day.Date >= firstDate && e.Day.Date <= lastDate)
                {
                    e.Cell.BackColor = System.Drawing.Color.DeepSkyBlue;
                    e.Cell.Font.Strikeout = true;
                }
            }
        }


        protected void izaberiSubmit_Click(object sender, EventArgs e)
        {

               datumPocetka = Convert.ToDateTime(beginDate.Text);
               datumZavrsetka = Convert.ToDateTime(endDate.Text);
               TimeSpan brojDana =  new TimeSpan();

            
            if (rezervacijaSession == null)
            {
                rezervacijaSession = new StavkeRezervacije();
                rezervacijaSession.RadnikId = radnikId;

                rezervacijaSession.DatumRezervacije = DateTime.Now;
                rezervacijaSession.DatumPocetka = datumPocetka;
                rezervacijaSession.DatumZavrsetka = datumZavrsetka;
                brojDana = Convert.ToDateTime(rezervacijaSession.DatumZavrsetka) -
                           Convert.ToDateTime(rezervacijaSession.DatumPocetka);
                //var dani = brojDana.Days;
                rezervacijaSession.BrojRadnihSati = Convert.ToInt32(brojDana.Days) * 8;
                Response.Redirect("Reservation.aspx");
            }
            
        }

        protected void novaRezervacija_SelectionChanged(object sender, EventArgs e)
        {


            //datumPocetka = novaRezervacija.SelectedDate;
            //datumZavrsetka = novaRezervacija.SelectedDate;
            //datumi = novaRezervacija.SelectedDates;
            //datumPocetka = novaRezervacija.SelectedDate;
            //datumi.Add(datumPocetka);
            //datumZavrsetka = novaRezervacija.SelectedDate;
            //datumi.Add(datumZavrsetka);


            //datumi.Add(datumPocetka);
            //datumi.Add(datumZavrsetka);

            //datumPocetka = datumi[1];
            //datumZavrsetka = datumi[2];


            //probati bez if
            //if (datumi.Count > 1)
            //{

            //}
        }



        protected void ponoviPretragu_Click(object sender, EventArgs e)
        {

            //radnici = null;

            if(rezervacijaSession != null)
            Session.RemoveAll();
            Response.Redirect("~/Default.aspx");
        }      
    }
}


       