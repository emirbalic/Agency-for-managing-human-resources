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
    public partial class PrikazRacunaZaUslugeForm : Form
    {
        private esp_RacunSelectDataOnly_Result dataOnly= new esp_RacunSelectDataOnly_Result();
        private int radnikId;
        private int rezervacijaId;

        public PrikazRacunaZaUslugeForm(int radnikID, int rezervacijaID)
        {
            InitializeComponent();  
                radnikId = radnikID;
                rezervacijaId = rezervacijaID;
        }

        private void FakturaZaKlijentaForm_Load(object sender, EventArgs e)
        {
            dataOnly = DAKlijenti.RacunSelectDataOnly(radnikId, rezervacijaId);

            radnikInput.Text = dataOnly.Puno_ime;
            rezervacijaInput.Text = Convert.ToString(rezervacijaId);
            datumRezervacijeInput.Text = Convert.ToString(dataOnly.DatumRezervacije);
            datumPocetkaInput.Text = Convert.ToString(dataOnly.DatumPocetka);
            datumZavršetkaInput.Text = Convert.ToString(dataOnly.DatumZavrsetka);
            nazivFirmeInput.Text = dataOnly.Naziv_Firme;
            brojRadnihSatiInput.Text = Convert.ToString(dataOnly.BrojRadnihSati);
            cijenaPoSatuInput.Text = Convert.ToString(dataOnly.CijenaPoSatu);
            ukupnoInput.Text = Convert.ToString(dataOnly.BrojRadnihSati * dataOnly.CijenaPoSatu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
