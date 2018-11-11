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
    public partial class RacunInsertAndInfoForm : Form
    {
        private esp_RezervacijeSelectByClientName_Result data;
        private string naziv;
        public RacunInsertAndInfoForm()
        {
            InitializeComponent();

        }

        private void RacunInsertAndInfoForm_Load(object sender, EventArgs e)
        {
            klijentiList.DataSource = DAKlijenti.KlijentiSelectNOArgs();
            klijentiList.DisplayMember = "Naziv";
            klijentiList.ValueMember = "Naziv";
        }

        private void klijentiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            naziv = Convert.ToString(klijentiList.SelectedValue);
            stavkeZaRacunGrid.DataSource = DAKlijenti.RezervacijeSelectByClientName(naziv);
            stavkeZaRacunGrid.Columns[0].Visible = false;
        }

        private void napraviRacunSubmit_Click(object sender, EventArgs e)
        {
            if (naziv != null)
            {
                data = DAKlijenti.RezervacijeSelectByClientNameSingle(naziv);
                int iznos = Convert.ToInt32(data.BrojRadnihSati*data.CijenaPoSatu);
                DialogResult dialogResult = MessageBox.Show(
                "Upisati slijedeće podatke u račun: Iznos= " + iznos + ", datum i vrijeme kreiranja računa: " +
                DateTime.Now,
                "Provjera upisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int racunId = DAKlijenti.RacuniInsert(iznos, data.RezervacijaId);
                    MessageBox.Show("Upisali ste racun u bazu. Referentni broj računa je: " + racunId);
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Ponovo provjerite podatke o računu.");
                    Close();
                    RacunInsertAndInfoForm noviRacun = new RacunInsertAndInfoForm();
                    noviRacun.Show();
                }               
            }
            else
            {
                MessageBox.Show(Global.GetString("select_miss"), "Upravljanje aplikacijom", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
