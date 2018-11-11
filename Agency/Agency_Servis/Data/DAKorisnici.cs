using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DAKorisnici
    {
        public static List<Uloge> UlogeSelectAll()
        {
            return Connection.dm.esp_UlogeSelectAll().ToList();
        }

        public static void KorisniciInsert(Korisnici k, Osobe o, List<Uloge> uloge, int mjestoId, string ulicaIBroj)
        {
            // note - (za larisu, a i za mene)
            //ovo sam riješio drugačije jer mi je korisnickoIme u dbo.korisnici, a drugi podaci u dbo.osoba, pa procedura unosi osobu a ne unosi 
            //korisnika, dakle postavio sam u proceduru uslov i ovaj korisnikId će ostatai nula ako ne unese sve.
            // u ovom slučaju kontstraint nema veze, ali ću ga ostaviti jer će raditi u slučaju 
            //promjene korisničkih podataka
            int korisnikId = 0;
            try
            {
                korisnikId = Convert.ToInt32(Connection.dm.esp_KorisniciInsert(o.Ime, o.Prezime, o.Email, o.Telefon, k.KorisnickoIme,
                                                       k.LozinkaSalt, k.LozinkaHash, mjestoId, ulicaIBroj).First());

            }
            catch (EntityException e)
            {

                Util.ExceptionHandler.HandleException(e);
            }    
                foreach (Uloge u in uloge)
                {
                    Connection.dm.esp_KorisniciUlogeInsert(korisnikId, u.UlogaId);
                }

        }

        public static List<Mjesta> MjestaSelectAll()
        {
            List<Mjesta> mjesta = Connection.dm.esp_MjestaSelectAll().ToList();
            Mjesta empty = new Mjesta();
            empty.DrzavaId = 0;
            empty.MjestoId = 0;
            empty.Naziv = "";
            empty.PostanskiBroj = "";
            mjesta.Insert(0, empty);
            return mjesta;

        }

        public static Korisnici SelectByKorisnickoIme(string korisnickoIme, string lozinka)
        {
            Korisnici k = Connection.dm.esp_KorisniciSelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

            if (k != null)
            {
                if (Util.UIHelper.GenerateHash(lozinka, k.LozinkaSalt) == k.LozinkaHash)
                {
                    k.Uloge = Connection.dm.esp_KorisniciUlogeSelectByKorisnik(k.KorisnikId).ToList();
                    return k;
                }
            }
            return null;
        }

        public static Object SelectByName(string imeIPrezime)
        {
            return Connection.dm.esp_KorisniciSelectByName(imeIPrezime).ToList();
        }

        public static void UpdateStatus(int korisnikId, bool status)
        {
            Connection.dm.esp_KorisniciUpdateStatus(korisnikId, status);
        }

        public static Korisnici SelectById(int korisnikId)
        {
            return Connection.dm.esp_KorisniciSelectById(korisnikId).First();
        }

        public static Osobe SelectOsobaByKorisnikId(int korisnikId)
        {
            return Connection.dm.esp_OsobeSelectByKorisnikID(korisnikId).First();
        }

        public static void UpdateLicnihPodataka(Osobe o, string ulicaIBroj, int mjestoId)
        {
            Connection.dm.esp_OsobeUpdateLicnihPodataka(o.OsobaId, o.Ime, o.Prezime, o.Email, o.Telefon, ulicaIBroj, mjestoId );
        }

        public static List<Uloge> SelectUlogeByKorisnik(int korisnikId)
        {
            return Connection.dm.esp_KorisniciUlogeSelectByKorisnik(korisnikId).ToList();
        }

        public static void ResetPassword(Korisnici k)
        {
            Connection.dm.esp_KorisniciResetPass(k.KorisnikId, k.LozinkaSalt, k.LozinkaHash);
        }

        public static void UlogeUpdate(int korisnikId, List<Uloge> uloge)
        {
            Connection.dm.esp_KorisniciUlogeDelete(korisnikId);

            foreach (var u in uloge)
            {
                Connection.dm.esp_KorisniciUlogeInsert(korisnikId, u.UlogaId);
            }
        }
    }
}
