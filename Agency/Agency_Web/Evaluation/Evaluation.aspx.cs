using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agency_Servis.Data;

namespace Agency_Web.Evaluation
{
    public partial class Evaluation : System.Web.UI.Page
    {
        public static int klijentId;
        public static int rezervacijaId;

        private string userName;

        protected Klijenti klijent;


        List<int> ocjene = new List<int>();

        protected List<esp_web_RezervacijaRadniciSelectByKlijentId_Result> listaRezervacija; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindList();
                BindGrid();
                BindLoop();
                HideStart();
            }
        }

        private void HideStart()
        {
            ocjeneList.Visible = false;
            primjedbaInput.Visible = false;
            sugestijeInput.Visible = false;
            evaluacijaSubmit.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
        }

        private void BindLoop()
        {
            ocjene = Enumerable.Range(1, 10).ToList();
            ocjeneList.DataSource = ocjene;
            ocjeneList.DataBind();

        }

        public void BindList()
        {
            userName = User.Identity.Name;
            Klijenti klijent = DAKlijenti.webSelectByKorisnickoIme_NoPassRequired(userName);
            klijentId = klijent.KlijentId;
            listaRezervacija = DAKlijenti.RezervacijaRadniciSelectByKlijentId(klijentId);

        }

        private void BindGrid()
        {
            listaRezervacijaGrid.DataSource = listaRezervacija;
            listaRezervacijaGrid.DataBind();
        }

        protected void listaRezervacijaGrid_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            if (e.CommandName == "pickReservation")
            {
                rezervacijaId = Convert.ToInt32(e.CommandArgument);
                listaRezervacijaGrid.Visible = false;
                headText.Visible = false;
                ShowStart();
            }
        }

        private void ShowStart()
        {
            ocjeneList.Visible = true;
            primjedbaInput.Visible = true;
            sugestijeInput.Visible = true;
            evaluacijaSubmit.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
        }

        protected void evaluacijaSubmit_Click(object sender, EventArgs e)
        {
            
            OcjenaUsluge o = Connection.dm.OcjenaUsluge.Where(x => x.RezervacijaId == rezervacijaId).FirstOrDefault();

            //varijabla za if klauzulu koja će spriječiti korisnika da ocjeni nezavršenu validaciju
            Rezervacija check
                = Connection.dm.Rezervacija.Where(r => r.RezervacijaId == rezervacijaId).FirstOrDefault();
            

            if (o == null )
            {
                //ne pravim provjeru za check!=null jer ne vidim kako bi i teorijski mogla biti null
                if (check.StavkeRezervacije.DatumZavrsetka < DateTime.Today)
                {
                    OcjenaUsluge ocjena = new OcjenaUsluge() { RezervacijaId = rezervacijaId };
                    ocjena.KlijentId = klijentId;
                    ocjena.Ocjena = Convert.ToInt32(ocjeneList.SelectedValue);
                    ocjena.Primjedba = primjedbaInput.Text;
                    ocjena.Sugestije = sugestijeInput.Text;
                    DAKlijenti.OcjenaUslugeInsert(ocjena.KlijentId, ocjena.RezervacijaId, ocjena.Ocjena, ocjena.Primjedba, ocjena.Sugestije);
                    Notification.Visible = true;
                    Hide();
                    Evaluated.Visible = false;
                }
                else
                {
                    Hide();
                    Evaluated.Visible = false;
                    UnEnded.Visible = true;
                }
                
            }
            else if(o.RezervacijaId == rezervacijaId)
            {
                Hide();
            }          
        }

        private void Hide()
        {
            Evaluated.Visible = true;
            Reload.Visible = true;
            listaRezervacijaGrid.Visible = false;
            ocjeneList.Visible = false;
            primjedbaInput.Visible = false;
            sugestijeInput.Visible = false;
            evaluacijaSubmit.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            headText.Visible = false;
        }

        protected void Reload_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

    }
}