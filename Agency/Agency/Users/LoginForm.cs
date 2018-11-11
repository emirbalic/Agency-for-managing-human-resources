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

namespace Agency.Users
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void prijavaSubmit_Click(object sender, EventArgs e)
        {
            Korisnici k = DAKorisnici.SelectByKorisnickoIme(korisnickoImeInput.Text, lozinkaInput.Text);
            if (k != null)
            {
                if (k.Uloge.Count > 0)
                {
                    Global.prijavljeniKorisnik = k;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show(Global.GetString("login_succ"), "Prijava na sistem");
                }
            }
            else
            {
                lozinkaInput.Text = "";
                MessageBox.Show(Global.GetString("login_err"), "Neuspješna prijava na sistem",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijavaSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prijavaSubmit_Click(sender, e);
        }

        private void odustaniSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                odustaniSubmit_Click(sender, e);
        }

        private void korisnickoImeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prijavaSubmit_Click(sender, e);
        }
    }
}
