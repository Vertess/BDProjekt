//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDProjekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oferent
    {
        public Oferent()
        {
            this.Dostawas = new HashSet<Dostawa>();
            this.OfertaOferentas = new HashSet<OfertaOferenta>();
        }
    
        public int IdOferenta { get; set; }
        public string Adres { get; set; }
        public string NazwaFirmy { get; set; }
    
        public virtual ICollection<Dostawa> Dostawas { get; set; }
        public virtual ICollection<OfertaOferenta> OfertaOferentas { get; set; }
    }
}
