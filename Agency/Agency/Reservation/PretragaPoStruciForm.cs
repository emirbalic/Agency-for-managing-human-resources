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
    public partial class PretragaPoStruciForm : Form
    {
        //ovdje struku već šaljem konstruktoru, jer sam probavao sa onom konverzijom u int pa nije išlo
        //ovo, elem, radi pa neka ostane
        private List<Struka> struka;
        private Radnici radnik;
 
        public PretragaPoStruciForm(List<Struka> s )
        {
            InitializeComponent();
            if (s != null)
            {
                struka = s;
                UcitajPodatke(struka);
            }
            
        }

        private void UcitajPodatke(List<Struka> struka)
        {
            strukaList.DataSource = struka;
            strukaList.DisplayMember = "Naziv";
            strukaList.ValueMember = "Naziv";
         
        }

        private void strukaList_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (strukaList.SelectedValue != null)
            {

                string naziv = Convert.ToString(strukaList.SelectedValue);
                RadniciGrid.DataSource = DARadnici.RadniciSelectByStrukaNaziv(naziv);
                RadniciGrid.Columns[0].Visible = false;
                RadniciGrid.Columns[1].Visible = false;

            }


        }

        private void provjeraDostupnostiSubmit_Click(object sender, EventArgs e)
        {
           
                if (radnik != null)
                {
                    Reservation.KalendarDostupnostiRadnikaForm kalendar = new KalendarDostupnostiRadnikaForm(radnik);
                    kalendar.Show();
                }
                else
                {
                    MessageBox.Show(Global.GetString("select_miss"), "Upravljanje aplikacijom", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            Close();
           
           
        }

        private void RadniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        { 

                int radnikId = Convert.ToInt32(RadniciGrid.SelectedRows[0].Cells[1].Value);
                radnik = DARadnici.RadnikSelectSingle(radnikId);

        }

        private void zatvoriSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        

       
    }
}
