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
    
    public partial class esp_KlijentiSelect_Result
    {
        public int KlijentId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int AdresaId { get; set; }
        public int MjestoId { get; set; }
        public int TipAktivnostiId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
    }
}