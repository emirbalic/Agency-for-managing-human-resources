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
    
    public partial class Adrese
    {
        public Adrese()
        {
            this.Klijenti = new HashSet<Klijenti>();
            this.Osobe = new HashSet<Osobe>();
        }
    
        public int AdresaId { get; set; }
        public string UlicaIBroj { get; set; }
    
        public virtual ICollection<Klijenti> Klijenti { get; set; }
        public virtual ICollection<Osobe> Osobe { get; set; }
    }
}
