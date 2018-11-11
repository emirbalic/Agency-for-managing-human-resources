using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DAIzvjestaji
    {
        public static List<esp_xrp_RezervacijeUPeriodu_Result> RezervacijeUPeriodu(DateTime datumOd, DateTime datumDo)
        {
            return Connection.dm.esp_xrp_RezervacijeUPeriodu(datumOd, datumDo).ToList();
        }
        public static List<esp_xrp_Racun_SelectByClientId_Result> RacunZaReport(int klijentId)
        {
            return Connection.dm.esp_xrp_Racun_SelectByClientId(klijentId).ToList();
        }
        public static List<esp_xrp_RadniciOsobeSelect_NoArgs_Result> RadniciOsobeSelectNoArgs()
        {

            List<esp_xrp_RadniciOsobeSelect_NoArgs_Result> radnici = Connection.dm.esp_xrp_RadniciOsobeSelect_NoArgs().ToList();
            var first = new esp_xrp_RadniciOsobeSelect_NoArgs_Result();
            first.Prezime_i_ime = "";
            first.RadnikId = 0;
            radnici.Insert(0, first);
            return radnici;
        }
    }
}
