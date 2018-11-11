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

namespace Agency.Reservation
{
    public partial class PregledRezervacijaForm : Form
    {
        public PregledRezervacijaForm()
        {
            InitializeComponent();
        }

        private void PregledRezervacijaForm_Load(object sender, EventArgs e)
        {
            radniciList.DataSource = DARadnici.RadniciSelectNamesOnly();
            radniciList.DisplayMember = "FULLNAME";
            radniciList.ValueMember = "RadnikID";
        }

        private void radniciList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radniciList.SelectedIndex == 0)
                rezervacijeGrid.DataSource = null;
            else
            {
                rezervacijeGrid.DataSource = DARadnici.RadniciRezervacijeByRadnikIdSelect(Convert.ToInt32(radniciList.SelectedValue));
                rezervacijeGrid.Columns[0].Visible = false;

            }
        }

        private void otkaziSubmit_Click(object sender, EventArgs e)
        {
            
            int radnikId = Convert.ToInt32(radniciList.SelectedValue);
            DateTime datumRezervacije = Convert.ToDateTime(rezervacijeGrid.SelectedRows[0].Cells[5].Value);
            if (radnikId != 0 && datumRezervacije != null)   //) && datumPocetka == DateTime.Now
                DARadnici.RezervacijaCancel(radnikId, datumRezervacije);
            else
            {
                MessageBox.Show(Global.GetString("reserve_cancel_err"), "Nedozvoljena akcija",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
