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
    public partial class UnosSkolskeSpremeForm : Form
    {
        public UnosSkolskeSpremeForm()
        {
            InitializeComponent();
        }

        private void spasiSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string naziv = skolskaSpremaText.Text.Trim();
                DAAdministracija.SkolskaSpremaInsert(naziv);
                MessageBox.Show(Global.GetString("education_succ"), "Nova školska sprema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //obavezno dodati i poruku o validaciji constrainta!!!
                skolskaSpremaText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Global.GetString(ex.Message));
                skolskaSpremaText.Clear();
            }
        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
