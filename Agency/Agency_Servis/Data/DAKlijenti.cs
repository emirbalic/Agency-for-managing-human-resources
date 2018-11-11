using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Data
{
    public class DAKlijenti
    {
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
       
        public static List<TipAktivnosti> TipAktivnostiSelectAll()
        {
            List<TipAktivnosti> tipAktivnosti = Connection.dm.esp_TipAktivnostiSelectAll().ToList();
            TipAktivnosti empty = new TipAktivnosti();
            empty.TipAktivnostiId = 0;
            empty.Naziv = "";
            tipAktivnosti.Insert(0, empty);
            return tipAktivnosti;
        }
     
        public static void KlijentiInsert(Klijenti klijent, Adrese adresa, int mjestoId, int tipAktivnostiId)
        {
            try
            {
                Connection.dm.esp_KlijentiInsert(klijent.Naziv, klijent.Telefon, klijent.Email, adresa.UlicaIBroj, mjestoId,
                                                     tipAktivnostiId,
                                                     klijent.KorisnickoIme, klijent.LozinkaSalt, klijent.LozinkaHash);
            }
            catch (EntityException e)
            {

                Util.ExceptionHandler.HandleException(e);
            }
        }
     
        public static esp_KlijentiSelectAllByNaziv_Result KlijentiSelectSingle(string naziv)
        {
            return Connection.dm.esp_KlijentiSelectAllByNaziv(naziv).FirstOrDefault();
        }
     
        public static Object KlijentiSelectAll(string naziv)
        {
            return Connection.dm.esp_KlijentiSelectAllByNaziv(naziv).ToList();
        }

        public static List<Klijenti> KlijentiSelectNOArgs()
        {

            List<Klijenti> klijenti = Connection.dm.esp_KlijentiSelect().ToList();
            Klijenti first = new Klijenti();
            first.Naziv = "Izaberite klijenta";
            first.AdresaId = 0;
            first.MjestoId = 0;
            first.TipAktivnostiId = 0;
            klijenti.Insert(0, first);
            return klijenti;

        }

        public static void KlijentiUpdateLicnihPodataka(string naziv, string telefon, string email, string ulicaIBroj, int mjestoId)
        {
            Connection.dm.esp_KlijentiUpdateLicnihPodataka(naziv, telefon, email, ulicaIBroj, mjestoId);
        }

        //public static void KlijentiUpdatePristupnihPodataka(string naziv, string korisnickoIme, string lozinkaSalt, string lozinkaHash)
        //{
        //    Connection.dm.esp_KlijentiResetPass(naziv, lozinkaSalt, lozinkaHash);
        //    Connection.dm.esp_KlijentiChangeUsername(naziv, korisnickoIme);
        //}


        //ipak je bolje imati razdvojeno...

        public static void KlijentiResetPass(string naziv, string lozinkaSalt, string lozinkaHash)
        {
            Connection.dm.esp_KlijentiResetPass(naziv, lozinkaSalt, lozinkaHash);
        }

        public static void KlijentiChangeUsername(string naziv, string korisnickoIme)
        {
            Connection.dm.esp_KlijentiChangeUsername(naziv, korisnickoIme);
        }

        //rezervacija koja se pravi sa desktop strane//
        public static void RezervacijaCreate (Rezervacija r, StavkeRezervacije stavke)
        {
            Connection.dm.esp_RezervacijaCreate(r.KlijentId, stavke.RadnikId, stavke.DatumRezervacije,
                                                 stavke.DatumPocetka,
                                                 stavke.DatumZavrsetka, stavke.BrojRadnihSati);
        }

        public static esp_RacunSelectDataOnly_Result RacunSelectDataOnly(int radnikId, int rezervacijaId)
        {
            return Connection.dm.esp_RacunSelectDataOnly(radnikId, rezervacijaId).First();
        }

        public static List<esp_RezervacijeSelectByClientName_Result> RezervacijeSelectByClientName(string naziv)
        {
            return Connection.dm.esp_RezervacijeSelectByClientName(naziv).ToList();
        }

        public static esp_RezervacijeSelectByClientName_Result RezervacijeSelectByClientNameSingle(string naziv)
        {
            return Connection.dm.esp_RezervacijeSelectByClientName(naziv).FirstOrDefault();
        }

        public static List<esp_RezervacijeSelectByKlijentId_Result> RezervacijeSelectByKlijentId(int klijentId)
        {
            return Connection.dm.esp_RezervacijeSelectByKlijentId(klijentId).ToList();
        }

        public static int RacuniInsert(int iznos, int rezervacijaId)
        {
            return Convert.ToInt32(Connection.dm.esp_RacunInsert(iznos, rezervacijaId).First());
        }
        
        public static esp_RacunSelectByClientId_Result RacunSelectByClientId(int klijentId, int rezervacijaId)
        {
            return Connection.dm.esp_RacunSelectByClientId(klijentId, rezervacijaId).SingleOrDefault();
        }
        
        public static esp_RacunSelectByRezervacijaId_Result RacunSelectByRezervacijaId(int rezervacijaId)
        {
            return Connection.dm.esp_RacunSelectByRezervacijaId(rezervacijaId).FirstOrDefault();
        }

        public static Klijenti KlijentiSelectToUpdateAccessDataByNaziv(string naziv)
        {
            return Connection.dm.esp_KlijentiSelectToUpdateAccessDataByNaziv(naziv).FirstOrDefault();
        }

        public static void webKlijentiInsert(string naziv, string email, string ulicaIBroj, int mjestoId, int tipAktivnostiId, string korisnickoIme,
            string lozinkaSalt, string lozinkaHash)
        {
            Connection.dm.esp_web_KlijentiInsert(naziv, email, ulicaIBroj, mjestoId, tipAktivnostiId, korisnickoIme,
                                                 lozinkaSalt, lozinkaHash);
        }

        public static Object webSelectByKorisnickoIme(string korisnickoIme, string lozinka)
        {
            Klijenti k = Connection.dm.esp_web_KlijentiSelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

            if (k != null)
            {
                if (Util.UIHelper.GenerateHash(lozinka, k.LozinkaSalt) == k.LozinkaHash)
                    return k;

                int fail = -1; // "Unijeli ste pogrešnu lozinku.";
                return fail;
  
                //throw new Exception();
            }
            return null;
        }

        public static Klijenti webSelectByKorisnickoIme_NoPassRequired(string korisnickoIme)
        {
            return Connection.dm.esp_web_KlijentiSelectByKorisnickoIme(korisnickoIme).FirstOrDefault();
        }

        public static List<esp_web_RezervacijaRadniciSelectByKlijentId_Result> RezervacijaRadniciSelectByKlijentId(
            int klijentId)
        {
            return Connection.dm.esp_web_RezervacijaRadniciSelectByKlijentId(klijentId).ToList();
        }

        public static void OcjenaUslugeInsert(int klijentId, int rezervacijaId, int ocjena, string primjedba,
                                              string sugestije)
        {
            Connection.dm.esp_web_OcjeneUslugeInsert(klijentId, rezervacijaId, ocjena, primjedba, sugestije);
        }
    }
}
