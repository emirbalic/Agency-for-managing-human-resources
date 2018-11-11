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
    public partial class PregledRezervacijaZaRačun : Form
    {
        public PregledRezervacijaZaRačun()
        {
            InitializeComponent();
        }

        private void PregledRezervacijaZaRačun_Load(object sender, EventArgs e)
        {
            radniciList.DataSource = DARadnici.RadniciSelectNamesOnly();
            radniciList.DisplayMember = "FULLNAME";
            radniciList.ValueMember = "RadnikID";
        }

        private void radniciList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ovo je ključna linija            
            if (radniciList.SelectedIndex == 0)
                racunGrid.DataSource = null;
            else
            {
                racunGrid.DataSource = DARadnici.RadniciRezervacijeByRadnikIdSelect(Convert.ToInt32(radniciList.SelectedValue));
                racunGrid.Columns[0].Visible = false;

            }
        }

        private void ispostaviRacunSubmit_Click(object sender, EventArgs e)
        {

            // ovdje moram napraviti validator kako ne bi padalo kad nema rezervazija

            int radnikId = Convert.ToInt32(radniciList.SelectedValue);
            int rezervacijaId = Convert.ToInt32(racunGrid.SelectedRows[0].Cells[0].Value);


            Reservation.PrikazRacunaZaUslugeForm ispostavaFakture = new PrikazRacunaZaUslugeForm(radnikId, rezervacijaId);
            ispostavaFakture.Show();




 
        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
