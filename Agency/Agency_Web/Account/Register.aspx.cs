using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using Agency_Servis.Data;
using Agency_Servis.Util;

namespace Agency_Web.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
               JustBind();
           }
        }

        private void JustBind()
        {
            mjestoList.DataSource = DAKorisnici.MjestaSelectAll().ToList();
            mjestoList.DataBind();
            tipAktivnostiList.DataSource = DAKlijenti.TipAktivnostiSelectAll().ToList();
            tipAktivnostiList.DataBind();
        }

        protected void registracijaSubmit_Click(object sender, EventArgs e)
        {
            

            Adrese adresa = new Adrese();
            adresa.UlicaIBroj = adresaInput.Text;

            Mjesta mjesto = new Mjesta();
            if (mjestoList.SelectedIndex != 0)
                mjesto.MjestoId = Convert.ToInt32(mjestoList.SelectedValue);

            TipAktivnosti tipAktivnosti = new TipAktivnosti();
            if (tipAktivnostiList.SelectedIndex != 0)
                tipAktivnosti.TipAktivnostiId = Convert.ToInt32(tipAktivnostiList.SelectedValue);

            Klijenti klijent = new Klijenti();
            klijent.Naziv = nazivInput.Text;
            klijent.KorisnickoIme = korisnickoImeInput.Text.Trim();
            klijent.Email = emailInput.Text;

            klijent.LozinkaSalt = UIHelper.GenerateSalt();
            klijent.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, klijent.LozinkaSalt);

           DAKlijenti.webKlijentiInsert(klijent.Naziv, klijent.Email, adresa.UlicaIBroj, mjesto.MjestoId, tipAktivnosti.TipAktivnostiId,
               klijent.KorisnickoIme, klijent.LozinkaSalt, klijent.LozinkaHash);

            //foreach (Control control in Form.Controls)  
            //{
            //    if (control is TextBox)
            //    {
            //        TextBox txt = (TextBox)control;
            //        txt.Text = "";
            //    }
            //} 
        }
    }
}