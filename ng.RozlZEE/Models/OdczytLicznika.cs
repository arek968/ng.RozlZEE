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
    
    public partial class OdczytLicznika
    {
        public int Id { get; set; }
        public System.DateTime DataOdczytu { get; set; }
        public string NrFabryczny { get; set; }
        public float Stan { get; set; }
        public float Zuzycie { get; set; }
        public bool PierwszyOdczyt { get; set; }
    
        public virtual Licznik Licznik { get; set; }
    }
}
