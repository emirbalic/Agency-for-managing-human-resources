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
    public partial class PregledStrucneSpremeForm : Form
    {
        public PregledStrucneSpremeForm()
        {
            InitializeComponent();
        }

        private void PregledStrucneSpremeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAAdministracija.SkolskaSpremaReport();
            dataGridView1.Columns[2].Visible = false;
        }
    }
}
