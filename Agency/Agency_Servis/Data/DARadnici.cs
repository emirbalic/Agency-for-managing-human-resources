using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DARadnici
    {
        public static int totalRows = 0;

        public static List<Struka> StrukeSelectAll()
        {
            List<Struka> struke = Connection.dm.esp_StrukaSelectAll().ToList();
            Struka empty = new Struka();
            empty.Naziv = "";
            empty.StrukaId = 0;
            struke.Insert(0, empty);

            return struke;
        }

        public static List<SkolskaSprema> SkolskaSpremaSelectAll()
        {
            List<SkolskaSprema> skolskaSprema = Connection.dm.esp_SkolskaSpremaSelectAll().ToList();
            SkolskaSprema empty = new SkolskaSprema();
            empty.Naziv = "";
            empty.SkolskaSpremaId = 0;
            skolskaSprema.Insert(0, empty);
            return skolskaSprema;
        }

        public static void RadniciInsert(Radnici r, Osobe o, string ulicaIBroj)
        {
            Connection.dm.esp_RadniciInsert(o.Ime, o.Prezime, o.JMBG, ulicaIBroj, o.MjestoId, o.Email, o.Telefon,
                                            r.StrukaId, r.SkolskaSpremaId, r.CijenaPoSatu);
        }

        public static esp_RadniciOsobeSelectAll_Result RadniciOsobeSelectAll(int radnikId)
        {
            return Connection.dm.esp_RadniciOsobeSelectAll(radnikId).FirstOrDefault();
        }
        
        public static List<esp_RadniciOsobeSelectByName_ToUpdate_Result> RadniciOsobeSelectByNameToUpdate(
            string imeIPrezime)
        {
            return Connection.dm.esp_RadniciOsobeSelectByName_ToUpdate(imeIPrezime).ToList();
        }

        public static esp_RadniciOsobeSelectById_ToUpdate_Result RadniciOsobeSelectByIdToUpdate(int radnikId)
        {
            return Connection.dm.esp_RadniciOsobeSelectById_ToUpdate(radnikId).FirstOrDefault();
        }

        //ova je samo testna za web. ako bude radila napraviću normalnu
        public static List<esp_RadniciOsobeSelectById_ToUpdate_Result> RadniciOsobeSelectByIdList(int radnikId)
        {
            return Connection.dm.esp_RadniciOsobeSelectById_ToUpdate(radnikId).ToList();
        }

        public static void RadniciUpdateStatus(int radnikId, bool status)
        {
            Connection.dm.esp_RadniciUpdateStatus(radnikId, status);
        }
        
        //ne koristim je jer mogu promjeniti status i preko objekta, ali neka je zasad.  
        public static Radnici RadnikSelectSingle(int radnikId)
        {
            return Connection.dm.esp_RadniciSelectByID(radnikId).SingleOrDefault();
        }

        public static void RadniciUpdateOsnovnihPodataka(int osobaId, int radnikId, string email, string telefon,
                                                         decimal cijena)
        {
            Connection.dm.esp_RadniciUpdateOsnovnihPodataka(osobaId, radnikId, telefon, email, cijena);
        }


        public static List<esp_RadniciSelectByStrukaNaziv_Result> RadniciSelectByStrukaNaziv(string naziv)
        {
            return Connection.dm.esp_RadniciSelectByStrukaNaziv(naziv).ToList();
        }

        public static List<esp_StrukeSelect_Result> getStruke()
        {
            return Connection.dm.esp_StrukeSelect().ToList();
        }

        public static List<StavkeRezervacije> StavkeRezervacijeSelectById (int radnikId)
        {
            return Connection.dm.esp_StavkeRezervacijeSelectByRadnikID(radnikId).ToList();
        }
        
        public static void RezervacijaCancel(int radnikId, DateTime datumRezervacije)
        {
            Connection.dm.esp_RezervacijeCancelByRadnikId(radnikId, datumRezervacije);
        }

        //funkcija koja zove proceduru na osnovu koje pravim račun
        public static Object RadniciSelectNamesOnly()
        {
            List<esp_RadniciSelectNamesOnly_Result> radnici = Connection.dm.esp_RadniciSelectNamesOnly().ToList();
            esp_RadniciSelectNamesOnly_Result empty = new esp_RadniciSelectNamesOnly_Result();
            empty.RadnikID = 0;
            empty.FULLNAME = "Izaberite ime i prezime radnika";
            radnici.Insert(0, empty);
            return radnici;
        }

        // ova puni datagrid
        public static Object RadniciRezervacijeByRadnikIdSelect(int radnikId)
        {
            return Connection.dm.esp_RadniciRezervacijeByRadnikId(radnikId).ToList();
        }

        //za report, slična ali bolje lista nego object
        public static List<esp_RadniciRezervacijeByRadnikId_Result> RadniciRezervacijeByRadnikIdSelectToList(int radnikId)
        {

            return Connection.dm.esp_RadniciRezervacijeByRadnikId(radnikId).ToList();


        }
         public static List<esp_RadniciRezervacijeByRadnikSurName_Result> RadniciRezervacijeByRadnikSurname(
             string prezime)
         {
             return Connection.dm.esp_RadniciRezervacijeByRadnikSurName(prezime).ToList();

         }
        public static List<esp_web_RadniciSelectByStrukaImeIPrezime_Result> RadniciSelectByStruka(int strukaId, string imeIPrezime, int offset,
                                                                                       int maxRows)
        {
            System.Data.Objects.ObjectParameter total = new System.Data.Objects.ObjectParameter("TotalRows", 0);
            List<esp_web_RadniciSelectByStrukaImeIPrezime_Result> radnici =
                Connection.dm.esp_web_RadniciSelectByStrukaImeIPrezime(strukaId, imeIPrezime, offset, maxRows, total).ToList();
            totalRows = Convert.ToInt32(total.Value);
            return radnici;
        }
    }
}
