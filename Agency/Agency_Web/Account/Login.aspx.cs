using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agency_Servis.Data;

namespace Agency_Web.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void loginBox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Object k = DAKlijenti.webSelectByKorisnickoIme(loginBox.UserName, loginBox.Password);


            try
            {
                if (k == null)
                {
                    loginBox.FailureText =
                        "Korisnik sa unesenim korisničkim imenom nije pronađen.";
                    
                    e.Authenticated = false;
                }
                else if (k is int)
                {
                    loginBox.FailureText = "Unijeli ste pogrešnu lozinku. Pokušajte ponovo";
                }
                else
                    e.Authenticated = true;
            }
            catch (Exception ex)
            {

                loginBox.FailureText = ex.Message;
                e.Authenticated = false;
            }


        }


    }
}