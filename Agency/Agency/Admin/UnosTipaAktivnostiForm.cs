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
    public partial class UnosTipaAktivnostiForm : Form
    {
        public UnosTipaAktivnostiForm()
        {
            InitializeComponent();
        }

        private void spasiSubmit_Click(object sender, EventArgs e)
        {
            string naziv = tipAktivnostiText.Text.Trim();
            try
            {
                DAAdministracija.TipAktivnostiInsert(naziv);
                MessageBox.Show(Global.GetString("activity_succ"), "Novi tip aktivnosti",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipAktivnostiText.Text = "";            
            }
            catch (Exception ex)
            {
                MessageBox.Show(Global.GetString(ex.Message));
            }

        }

        private void odustaniSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
