//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agency_Servis.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class StavkeRezervacije
    {
        public StavkeRezervacije()
        {
            this.Rezervacija = new HashSet<Rezervacija>();
        }
    
        public int StavkeRezervacijeId { get; set; }
        public int RadnikId { get; set; }
        public Nullable<System.DateTime> DatumRezervacije { get; set; }
        public Nullable<System.DateTime> DatumPocetka { get; set; }
        public Nullable<System.DateTime> DatumZavrsetka { get; set; }
        public Nullable<bool> StatusRezervacije { get; set; }
        public int BrojRadnihSati { get; set; }
    
        public virtual Radnici Radnici { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}