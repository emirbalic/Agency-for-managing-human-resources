using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DAAdministracija
    {
        public static void UlogeInsert(string naziv)
        {
            Connection.dm.esp_UlogeInsert(naziv);
        }
        public static void StrukeInsert(string naziv)
        {
            Connection.dm.esp_StrukaInsert(naziv);
        }
        public static void SkolskaSpremaInsert(string naziv)
        {
            Connection.dm.esp_SkolskaSpremaInsert(naziv);
        }
        public static void TipAktivnostiInsert(string naziv)
        {
            Connection.dm.esp_TipAktivnostiInsert(naziv);
        }
        public static List<Uloge> UlogeSelectByKorisnikId(int korisnikId)
        {
            return Connection.dm.esp_UlogeSelectByKorisnikId(korisnikId).ToList();
        }

        public static List<Struka> StrukeReport()
        {
            return Connection.dm.esp_StrukaSelectAll().ToList();                     
        }
        public static List<SkolskaSprema> SkolskaSpremaReport()
        {
            return Connection.dm.esp_SkolskaSpremaSelectAll().ToList();            
        }
        public static List<Uloge> UlogeReport()
        {
            return Connection.dm.esp_UlogeSelectAll().ToList();
        }
        public static List<TipAktivnosti> TipAktivnostiReport()
        {
            return Connection.dm.esp_TipAktivnostiSelectAll().ToList();           
        }
        public static List<Mjesta> MjestaReport()
        {
            return Connection.dm.esp_MjestaSelectAll().ToList();
        }
    }
}
