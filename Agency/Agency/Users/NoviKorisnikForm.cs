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

namespace Agency.Users
{
    public partial class NoviKorisnikForm : Form
    {
        public NoviKorisnikForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }


        private void Clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            emailInput.Text = "";
            telefonInput.Text = "";
            korisnickoImeInput.Text = "";
            lozinkaInput.Text = "";
            mjestaList.SelectedIndex = 0;
            ulicaIBrojInput.Text = "";

            foreach (int i in ulogeList.CheckedIndices)
            {
                ulogeList.SetItemCheckState(i, CheckState.Unchecked);
            } 
        }


        private void odustaniSubmit_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dodajSubmit_Click_1(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Korisnici k = new Korisnici();
                Osobe o = new Osobe();

                string ulicaIBroj = ulicaIBrojInput.Text;

                int MjestoId = Convert.ToInt32(mjestaList.SelectedValue);

                o.Ime = imeInput.Text;
                o.Prezime = prezimeInput.Text;
                o.Email = emailInput.Text;
                o.Telefon = telefonInput.Text;

                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);

                List<Uloge> uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                try
                {
                    DAKorisnici.KorisniciInsert(k, o, uloge, MjestoId, ulicaIBroj);
                    MessageBox.Show(Global.GetString("user_succ"), "Novi korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Izaberite drugo korisničko ime ili email adresu", 
                        "Validacija unosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                Clear();
            }
        }


        private void NoviKorisnikForm_Load_1(object sender, System.EventArgs e)
        {

            mjestaList.DataSource = DAKorisnici.MjestaSelectAll();
            mjestaList.DisplayMember = "Naziv";
            mjestaList.ValueMember = "MjestoId";
            ulogeList.DataSource = DAKorisnici.UlogeSelectAll();
            ulogeList.DisplayMember = "Naziv";

        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (imeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Global.GetString("input_req_name"));
            }

        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (prezimeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Global.GetString("input_req_surname"));
            }

        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (emailInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Global.GetString("input_req_email"));
                return;
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

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Global.GetString("input_req_user"));
            }

        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            //Regex.IsMatch(lozinkaInput, "^[a-zA-Z0-9]+$")
            if (lozinkaInput.Text.Trim().Length < 4)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetString("input_pass_err"));
            }

        }

        private void ulicaIBrojInput_Validating(object sender, CancelEventArgs e)
        {
            if (ulicaIBrojInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(ulicaIBrojInput, Global.GetString("input_address_err"));
            }
        }

    }
}

