using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DAPreporuka
    {
        public static List<esp_web_PreporukaPoOcjeni_Result> PreporukaPoOcjeni()
        {
            return Connection.dm.esp_web_PreporukaPoOcjeni().ToList();
        }

        public static List<esp_web_PreporukaPoStruci_Result> PreporukaPoStruci(int strukaId)
        {
            return Connection.dm.esp_web_PreporukaPoStruci(strukaId).ToList();
        }
    }
}
