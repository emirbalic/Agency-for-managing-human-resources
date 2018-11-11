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
namespace Agency.Workers
{
    public partial class NoviRadnikForm : Form
    {
        public NoviRadnikForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void NoviRadnikForm_Load(object sender, EventArgs e)
        {
            gradList.DataSource = DAKorisnici.MjestaSelectAll();
            gradList.DisplayMember = "Naziv";
            gradList.ValueMember = "MjestoId";

            strukaList.DataSource = DARadnici.StrukeSelectAll();
            strukaList.DisplayMember = "Naziv";
            strukaList.ValueMember = "StrukaId";

            strucnaSpremaList.DataSource = DARadnici.SkolskaSpremaSelectAll();
            strucnaSpremaList.DisplayMember = "Naziv";
            strucnaSpremaList.ValueMember = "SkolskaSpremaId";
        }

        private void snimiSubmit_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Osobe o = new Osobe();
                Radnici r = new Radnici();



                o.Ime = imeInput.Text.Trim();
                o.Prezime = prezimeInput.Text.Trim();
                o.JMBG = jmbgInput.Text.Trim();
                o.Email = emailInput.Text;
                o.Telefon = telefonInput.Text;
                o.MjestoId = Convert.ToInt32(gradList.SelectedValue);
                string ulicaIBroj = ulicaIBrojInput.Text;

                r.StrukaId = Convert.ToInt32(strukaList.SelectedValue);
                r.SkolskaSpremaId = Convert.ToInt32(strucnaSpremaList.SelectedValue);
                //r.CijenaPoSatu = decimal.Parse(cijenaInput.Text);
                r.CijenaPoSatu = Convert.ToDecimal(cijenaInput.Text.Trim());   //

                try
                {

                    DARadnici.RadniciInsert(r, o, ulicaIBroj);
                    MessageBox.Show(Global.GetString("work_succ"), "Unos podataka o radniku", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(Global.GetString(ex.Message));
                }


                DialogResult result = MessageBox.Show(Global.GetString("work_new_input"), "Podaci o novom radniku", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.OK:
                        Clear();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
            


        }

        private void Clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            jmbgInput.Text = "";
            emailInput.Text = "";
            telefonInput.Text = "";
            ulicaIBrojInput.Text = "";
            cijenaInput.Text = "";
            gradList.SelectedIndex = 0;
            strucnaSpremaList.SelectedIndex = 0;
            strukaList.SelectedIndex = 0;
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ulicaIBrojInput_Validating(object sender, CancelEventArgs e)
        {
            if (ulicaIBrojInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(ulicaIBrojInput, Global.GetString("input_address_err"));
            }
        }

        private void gradList_Validating(object sender, CancelEventArgs e)
        {
            if (gradList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(gradList, Global.GetString("city_err"));
            }
           
        }



        private void strukaList_Validating(object sender, CancelEventArgs e)
        {
            if (strukaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(strukaList, Global.GetString("proff_err"));
            }
        }

        private void strucnaSpremaList_Validating(object sender, CancelEventArgs e)
        {
            if (strucnaSpremaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(strucnaSpremaList, Global.GetString("edu_level_err"));
            }

        }

        private void cijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (cijenaInput.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(cijenaInput, Global.GetString("price_err"));
            }
        }










    }
}
