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
    public partial class UnosStrukeForm : Form
    {
        public UnosStrukeForm()
        {
            InitializeComponent();
        }

        private void spasiSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string naziv = strukaText.Text.Trim();
                DAAdministracija.StrukeInsert(naziv);
                MessageBox.Show(Global.GetString("proff_succ"), "Nova struka",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                strukaText.Text = "";
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
