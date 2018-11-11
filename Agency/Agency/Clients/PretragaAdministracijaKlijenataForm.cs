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

namespace Agency.Clients
{
    public partial class PretragaAdministracijaKlijenataForm : Form
    {
        private esp_KlijentiSelectAllByNaziv_Result klijentSingle;


        public PretragaAdministracijaKlijenataForm()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            klijentiGrid.DataSource = DAKlijenti.KlijentiSelectAll(imeIPrezimeInput.Text);
            klijentiGrid.ClearSelection();
        }

        private void PretragaAdministracijaKlijenataForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void imeIPrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void klijentiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string naziv = Convert.ToString(klijentiGrid.SelectedRows[0].Cells[0].Value);
            klijentSingle = DAKlijenti.KlijentiSelectSingle(naziv);

        }

        private void korisnickiMenu_Click(object sender, EventArgs e)
        {
            if (klijentSingle != null)
            {
                IzmjenaLicnihPodatakaForm izmjena = new IzmjenaLicnihPodatakaForm(klijentSingle);
                izmjena.Show();
            }
            else
            {
                GetValue();
            }
        }

        private static void GetValue()
        {
            MessageBox.Show(Global.GetString("select_miss"), "Upravljanje aplikacijom", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void pristupMenu_Click(object sender, EventArgs e)
        {
            if (klijentSingle != null)
            {
                IzmjenaPristupnihPodatakaForm izmjena = new IzmjenaPristupnihPodatakaForm(klijentSingle);
                izmjena.Show();
            }
            else
            {
                GetValue();
            }
        }

        private void infoOKlijentu_Click(object sender, EventArgs e)
        {
            if (klijentSingle != null)
            {
                InfoOKlijentuForm info = new InfoOKlijentuForm(klijentSingle);
                info.Show();
            }
            else
            {
                GetValue();
            }
        }

        private void izadjiSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
