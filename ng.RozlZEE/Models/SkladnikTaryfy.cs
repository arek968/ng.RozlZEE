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
    
    public partial class SkladnikTaryfy
    {
        public SkladnikTaryfy()
        {
            this.Cena = new HashSet<Cena>();
            this.PozycjaZuzycia = new HashSet<PozycjaZuzycia>();
            this.Licznik = new HashSet<Licznik>();
        }
    
        public int Id { get; set; }
        public byte TypCeny { get; set; }
        public byte BruttoNetto { get; set; }
        public bool WyliczacKwoty { get; set; }
        public decimal KwotaZuzycia { get; set; }
        public bool StalaZmienna { get; set; }
        public Nullable<byte> Kolejnosc { get; set; }
    
        public virtual Asortyment Asortyment { get; set; }
        public virtual ICollection<Cena> Cena { get; set; }
        public virtual JednostkaMiary JednostkaMiary { get; set; }
        public virtual ICollection<PozycjaZuzycia> PozycjaZuzycia { get; set; }
        public virtual Taryfa Taryfa { get; set; }
        public virtual ICollection<Licznik> Licznik { get; set; }
    }
}
