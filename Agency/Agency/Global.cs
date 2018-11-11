using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Agency_Servis.Data;

namespace Agency
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }

        public static string GetString(string key)
        {
            ResourceManager RM = new ResourceManager("Agency.Poruke", Assembly.GetExecutingAssembly());
            return RM.GetString(key);
        }
    }

}
