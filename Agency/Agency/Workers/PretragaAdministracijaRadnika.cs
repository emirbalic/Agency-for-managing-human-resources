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

namespace Agency.Workers
{
    public partial class PretragaAdministracijaRadnika : Form
    {
        private esp_RadniciOsobeSelectById_ToUpdate_Result radnik;
        private esp_RadniciOsobeSelectAll_Result radnikSingle;
        public PretragaAdministracijaRadnika()
        {
            InitializeComponent();
        }

        private void PretragaAdministracijaRadnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {

            radniciGrid.DataSource = DARadnici.RadniciOsobeSelectByNameToUpdate(imeIPrezimeInput.Text);
            radniciGrid.Columns[0].Visible = false;
            radniciGrid.Columns[1].Visible = false;
            radniciGrid.ClearSelection();
        }

        private void imeIPrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void radniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int radnikId = Convert.ToInt32(radniciGrid.SelectedRows[0].Cells[0].Value);
            radnik = DARadnici.RadniciOsobeSelectByIdToUpdate(radnikId);
            radnikSingle = DARadnici.RadniciOsobeSelectAll(radnikId);

        }

        private void deaktivirajSubmit_Click(object sender, EventArgs e)
        {
            if (radnik != null)
            {
                if ((bool)radniciGrid.SelectedRows[0].Cells[7].Value && (bool)radnik.Status)
                {
                    DARadnici.RadniciUpdateStatus(radnik.RadnikId, false);
                    BindGrid();
                    MessageBox.Show(Global.GetString("worker_deact") + radnik.Prezime + " " + radnik.Ime, "Deaktivacija");
                }
                else
                {
                    MessageBox.Show(Global.GetString("deact_err"), "Nedozvoljena operacija", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
            }
            else
            {
                GetValue();
 
            }
        }
        private void reaktivnirajSubmit_Click(object sender, EventArgs e)
        {
            if(radnik != null)
            {
                    DARadnici.RadniciUpdateStatus(radnik.RadnikId, true);
                    BindGrid();
                    MessageBox.Show(Global.GetString("worker_react") + radnik.Prezime + " " + radnik.Ime, "Ponovna aktivacija");                 
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

        private void licniSubmit_Click(object sender, EventArgs e)
        {
            if (radnik != null)
            {
                IzmjenaOsnovnihPodatakaForm izmjena = new IzmjenaOsnovnihPodatakaForm(radnik);
                izmjena.Show();
                BindGrid();
            }
            else
            {
                GetValue();
            }
        }

        private void infoSubmit_Click(object sender, EventArgs e)
        {
            if (radnikSingle != null)
            {
                InfoORadniku info = new InfoORadniku(radnikSingle);
                info.Show();
            }
            else
            {
                GetValue();
            }
 
        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
