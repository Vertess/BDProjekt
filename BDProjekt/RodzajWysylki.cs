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
    
    public partial class RodzajWysylki
    {
        public RodzajWysylki()
        {
            this.Zamowienies = new HashSet<Zamowieny>();
        }
    
        public int IdRodzajWysylki { get; set; }
        public int Cena { get; set; }
        public string Nazwa { get; set; }
    
        public virtual ICollection<Zamowieny> Zamowienies { get; set; }
    }
}
