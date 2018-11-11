using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency_Servis.Data;

namespace Agency_Servis.Util
{
    public class Recommendation
    {
        private static Dictionary<int, List<OcjenaUsluge>> radnici = new Dictionary<int, List<OcjenaUsluge>>();
        //private static List<OcjenaUsluge> ocjene = new List<OcjenaUsluge>();
        #region Item-based preporuka

        public static List<Radnici> GetSlicneRadnike(int radnikId)
        {
            //Ovu sam liniju koda dodao jer je padala aplikacija na zadnjoj liniji UčitajRadnike
            if (radnici != null)
                radnici.Clear();

            UcitajRadnike(radnikId);
            List<OcjenaUsluge> 
            ocjene =
                Connection.dm.OcjenaUsluge.Where(o => o.Rezervacija.StavkeRezervacije.Radnici.RadnikId == radnikId)
                          .OrderBy(o => o.KlijentId)
                          .ToList();
            List<OcjenaUsluge> zajednickeOcjene1 = new List<OcjenaUsluge>();
            List<OcjenaUsluge> zajednickeOcjene2 = new List<OcjenaUsluge>();

            List<Radnici> preporuceno = new List<Radnici>();


            foreach (var item in radnici)
            {
                foreach (OcjenaUsluge ocjena1 in ocjene) //Sve ocjene aktivnog proizvoda
                {
                    //Provjeriti da li je naredni proizvod (iz liste proizvodi) ocijenio isti kupac
                    if (item.Value.Where(x => x.KlijentId == ocjena1.KlijentId).Count() != 0)
                    {
                        zajednickeOcjene1.Add(ocjena1);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KlijentId == ocjena1.KlijentId).First());
                    }
                }

                //Za računanje sličnosti se uzimaju samo zajedničke ocjene, odnosno ocjene istih kupaca za oba proizvoda
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.6) //Granična vrijednost (treshold)
                    preporuceno.Add(DARadnici.RadnikSelectSingle(item.Key));

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();

            }
            return preporuceno;

        }


        private static double GetSlicnost(List<OcjenaUsluge> ocjene1, List<OcjenaUsluge> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
                return 0;

            int brojnik = 0;
            double int1 = 0;
            double int2 = 0;

            for (int i = 0; i < ocjene1.Count; i++)
            {
                brojnik += ocjene1[i].Ocjena * ocjene2[i].Ocjena;
                int1 += ocjene1[i].Ocjena * ocjene1[i].Ocjena;
                int2 += ocjene2[i].Ocjena * ocjene2[i].Ocjena;
            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            double nazivnik = int1 * int2;

            if (nazivnik != 0)
                return brojnik / nazivnik;

            return 0;

        }

        private static void UcitajRadnike(int radnikId)
        {
            List<Radnici> aktivniRadnici =
                Connection.dm.Radnici.Where(r => r.Status == true && r.RadnikId != radnikId).ToList();


            //System.Diagnostics.Debug.Write(aktivniRadnici);

            List<OcjenaUsluge> ocjene = new List<OcjenaUsluge>();          //List<OcjenaUsluge> ocjene = new List<OcjenaUsluge>();
            foreach (Radnici item in aktivniRadnici)
            {
                      ocjene = Connection.dm.OcjenaUsluge.Where(
                        o => o.Rezervacija.StavkeRezervacije.Radnici.RadnikId == item.RadnikId)
                              //.Distinct()
                              .OrderBy(x => x.KlijentId)
                              .ToList();
                if(ocjene.Count > 0)
                    radnici.Add(item.RadnikId, ocjene);

            }
        }

        #endregion
    }
}


//ocjene = (from o in Connection.dm.OcjenaUsluge
//          join r in Connection.dm.Rezervacija
//              on o.RezervacijaId equals r.RezervacijaId
//          join sr in Connection.dm.StavkeRezervacije
//              on r.StavkeRezervacijeId equals sr.StavkeRezervacijeId
//          join rd in Connection.dm.Radnici
//              on sr.RadnikId equals rd.RadnikId
//          join k in Connection.dm.Klijenti
//            on o.KlijentId equals k.KlijentId
//            orderby k.KlijentId
//          where rd.RadnikId == item.RadnikId
//          select o
//          ).ToList();