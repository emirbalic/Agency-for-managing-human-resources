using System;
using System.Collections.Generic;
using System.Linq;
using Agency_Servis.Data;
using Agency_Servis.Util;
using Microsoft.AspNet.Membership.OpenAuth;

namespace Agency_Web.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected bool CanRemoveExternalLogins
        {
            get;
            private set;
        }

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                Validation.Visible = false;
                SuccPass.Visible = false;
            }

        }

      





        protected static string ConvertToDisplayDateTime(DateTime? utcDateTime)
        {
            // You can change this method to convert the UTC date time into the desired display
            // offset and format. Here we're converting it to the server timezone and formatting
            // as a short date and a long time string, using the current thread culture.
            return utcDateTime.HasValue ? utcDateTime.Value.ToLocalTime().ToString("G") : "[never]";
        }

        protected void promijeniPassSubmit_Click(object sender, EventArgs e)
        {
            string novaLozinka = NewPassword.Text.Trim();
            string staraLozinka = CurrentPassword.Text.Trim();
            
            Klijenti klijent = new Klijenti();
            string userName = User.Identity.Name;
            klijent = DAKlijenti.webSelectByKorisnickoIme_NoPassRequired(userName);


            //string hash = Convert.ToString(Connection.dm.Klijenti.Where(x => x.LozinkaHash == klijent.LozinkaHash).FirstOrDefault());
            //Klijenti check = new Klijenti();
            //check.LozinkaSalt = UIHelper.GenerateSalt();
            //check.LozinkaHash = UIHelper.GenerateHash(staraLozinka, check.LozinkaSalt);

            //if (check.LozinkaHash == klijent.LozinkaHash)
            //{
           


            klijent.LozinkaSalt = UIHelper.GenerateSalt();
            klijent.LozinkaHash = UIHelper.GenerateHash(novaLozinka, klijent.LozinkaSalt);
            DAKlijenti.KlijentiResetPass(klijent.Naziv, klijent.LozinkaSalt, klijent.LozinkaHash);
            Hide();
  
            SuccPass.Visible = true;
            


            //}        
            //else
            //{
            //    Hide();
            //    Validation.Visible = true;
            //}


        }

        private void Hide()
        {
            
            CurrentPassword.Visible = false;
            CurrentPasswordLabel.Visible = false;
            NewPassword.Visible = false;
            NewPasswordLabel.Visible = false;
            ConfirmNewPassword.Visible = false;
            ConfirmNewPasswordLabel.Visible = false;
            promijeniPassSubmit.Visible = false;
        }






    }
}