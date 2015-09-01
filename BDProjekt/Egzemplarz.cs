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
    
    public partial class Egzemplarz
    {
        public Egzemplarz()
        {
            this.ElementyDostawies = new HashSet<ElementyDostawy>();
            this.ElementyZamowienias = new HashSet<ElementyZamowienia>();
            this.OfertaOferentas = new HashSet<OfertaOferenta>();
        }
    
        public int IdEgzemplarza { get; set; }
        public int Cena { get; set; }
        public int Iloscc { get; set; }
        public bool TypOkladki { get; set; }
        public int Ksiazka_IdKsiazki { get; set; }
        public int Wydawnictwo_IdWydawnictwa { get; set; }
    
        public virtual Ksiazka Ksiazka { get; set; }
        public virtual Wydawnictwo Wydawnictwo { get; set; }
        public virtual ICollection<ElementyDostawy> ElementyDostawies { get; set; }
        public virtual ICollection<ElementyZamowienia> ElementyZamowienias { get; set; }
        public virtual ICollection<OfertaOferenta> OfertaOferentas { get; set; }
    }
}
