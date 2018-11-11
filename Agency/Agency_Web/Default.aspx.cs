using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agency_Servis.Data;


namespace Agency_Web
{
    public partial class _Default : Page
    {
        //test ind changed
        public static int strukaId = 0;

        protected List<Struka> struke;
        protected List<esp_web_RadniciSelectByStrukaImeIPrezime_Result> radnici;
        protected List<esp_web_PreporukaPoOcjeni_Result> PreporukaPoOcjeni;
        protected List<esp_web_PreporukaPoStruci_Result> PreporukaPoStruci;
 
        //test ind changed
        //protected int strukaId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindStruke();
            poStruciGrid.Visible = false;

        }
        private void BindStruke()
        {
            struke = DARadnici.StrukeSelectAll();
            strukaList.DataBind();
        }
 

        protected void traziSubmit_Click(object sender, EventArgs e)
        {           
            BindGrid();
            Recommend();
        }

        private void Recommend()
        {
            people.Visible = false;
             if (strukaList.SelectedIndex != 0)
             {
                 hTxtProff.Visible = true;
                 headText.Visible = false;
                 strukaId = Convert.ToInt32(strukaList.SelectedValue);
                 PreporukaPoStruci = DAPreporuka.PreporukaPoStruci(strukaId);
                 poStruciGrid.DataBind();
                 poStruciGrid.Visible = true;
             }
             else
             {
                 people.Visible = true;
             }

        }
        private void BindGrid()
        {
            strukaId = 0;
            if (strukaList.SelectedIndex != 0)
                strukaId = Convert.ToInt32(strukaList.SelectedValue);
            int offset = radniciGrid.CurrentPageIndex * radniciGrid.PageSize;
            radnici = DARadnici.RadniciSelectByStruka(strukaId, imeIPrezimeInput.Text, offset, radniciGrid.PageSize);
            radniciGrid.VirtualItemCount = DARadnici.totalRows;
            radniciGrid.DataBind();



        }

        protected void radniciGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {

            radniciGrid.CurrentPageIndex = e.NewPageIndex;
            BindGrid();
        }



        protected void radniciGrid_ItemCommand1(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "checkReserved")
            {
                int RadnikId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("Reservation/Calendar.aspx?RadnikId=" + RadnikId);
            }
        }






    }
}