using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency_Servis.Data;
using Agency_Servis.Util;

namespace Agency.Clients
{
    public partial class NoviKlijentForm : Form
    {
        Klijenti klijent = new Klijenti();
        Adrese adresa = new Adrese();
        private int mjestoId;
        private int tipAktivnostiId;


        Mjesta mjesto = new Mjesta();
        Drzave drzava = new Drzave();

        public NoviKlijentForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void NoviKlijentForm_Load(object sender, EventArgs e)
        {
            BindList();
        }
        private void BindList()
        {
            mjestaList.DataSource = DAKorisnici.MjestaSelectAll();
            mjestaList.DisplayMember = "Naziv";
            mjestaList.ValueMember = "MjestoId";

            tipAktivnostiList.DataSource = DAKlijenti.TipAktivnostiSelectAll();
            tipAktivnostiList.DisplayMember = "Naziv";
            tipAktivnostiList.ValueMember = "TipAktivnostiId";
        }

        private void dodajSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                if (mjestaList.SelectedValue != null)
                {
                    mjestoId = Convert.ToInt32(mjestaList.SelectedValue);
                    klijent.MjestoId = mjestoId;
                }
                if (tipAktivnostiList.SelectedValue != null)
                {
                    tipAktivnostiId = Convert.ToInt32(tipAktivnostiList.SelectedValue);
                    klijent.TipAktivnostiId = tipAktivnostiId;

                }
                klijent.Naziv = nazivInput.Text.Trim();
                klijent.Telefon = telefonInput.Text.Trim();
                klijent.Email = emailInput.Text.Trim();

                klijent.KorisnickoIme = korisnickoImeInput.Text.Trim();
                klijent.LozinkaSalt = Agency_Servis.Util.UIHelper.GenerateSalt();
                klijent.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, klijent.LozinkaSalt);

                adresa.UlicaIBroj = ulicaBrojInput.Text;


                try
                {
                    DAKlijenti.KlijentiInsert(klijent, adresa, mjestoId, tipAktivnostiId);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(Global.GetString(ex.Message), "Validacija podataka", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    ClearForm();
                    return;
                }
                MessageBox.Show(Global.GetString("client_succ"), "Novi klijent", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ClearForm();

            }
            
        }
        private void ClearForm()
        {

            mjestaList.SelectedIndex = 0;
            tipAktivnostiList.SelectedIndex = 0;
            nazivInput.Text = "";
            telefonInput.Text = "";
            emailInput.Text = "";
            ulicaBrojInput.Text = "";
            ulicaBrojInput.Text = "";
            korisnickoImeInput.Text = "";
            lozinkaInput.Text = "";
            BindList();
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (nazivInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Global.GetString("title_con"));
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (telefonInput.Text == "")
                e.Cancel = true;
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (emailInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Global.GetString("input_req_email"));            
            }
            try
            {
                MailAddress mail = new MailAddress(emailInput.Text);
            }
            catch (Exception)
            {

                e.Cancel = true;
                errorProvider.SetError(emailInput, Global.GetString("email_false"));
            }

        }

        private void ulicaBrojInput_Validating(object sender, CancelEventArgs e)
        {
            if (ulicaBrojInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(ulicaBrojInput, Global.GetString("input_address_err"));
            }
                
        }

        private void mjestaList_Validating(object sender, CancelEventArgs e)
        {
            if (mjestaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(mjestaList, Global.GetString("city_err"));
            }

        }

        private void tipAktivnostiList_Validating(object sender, CancelEventArgs e)
        {
            if (tipAktivnostiList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tipAktivnostiList, Global.GetString("activity_con"));
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Global.GetString("input_req_user"));
            }
                
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (lozinkaInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetString("input_pass_err"));

            }
        }
    }
}
