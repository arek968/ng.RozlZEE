//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ng.RozlZEE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PozycjaZuzycia
    {
        public int Id { get; set; }
        public Nullable<float> Ilosc { get; set; }
        public string JednostkaMiary { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public Nullable<int> idStawkaVAT { get; set; }
        public Nullable<decimal> StawkaVAT { get; set; }
        public Nullable<decimal> KwotaNetto { get; set; }
        public Nullable<decimal> KwotaVAT { get; set; }
        public Nullable<decimal> KwotaBrutto { get; set; }
    
        public virtual Asortyment Asortyment { get; set; }
        public virtual SkladnikTaryfy SkladnikTaryfy { get; set; }
        public virtual Zuzycie Zuzycie { get; set; }
    }
}
