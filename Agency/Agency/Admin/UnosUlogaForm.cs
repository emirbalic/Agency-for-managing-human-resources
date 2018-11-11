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

namespace Agency.Admin
{
    public partial class UnosUlogaForm : Form
    {
        public UnosUlogaForm()
        {
            InitializeComponent();
        }

        private void spasiSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string naziv = ulogaText.Text.Trim();
                DAAdministracija.UlogeInsert(naziv);
                MessageBox.Show(Global.GetString("role_succ"), "Nova uloga",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ulogaText.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(Global.GetString(ex.Message));
            }
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
