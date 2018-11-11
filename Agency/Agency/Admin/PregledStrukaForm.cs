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
    public partial class PregledStrukaForm : Form
    {
        public PregledStrukaForm()
        {
            InitializeComponent();
        }

        private void PregledStrukaForm_Load(object sender, EventArgs e)
        {
            StrukeGrid.DataSource = DAAdministracija.StrukeReport();
            StrukeGrid.Columns[2].Visible = false;
        }


    }
}
