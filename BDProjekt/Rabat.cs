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
    
    public partial class Rabat
    {
        public Rabat()
        {
            this.Zamowienies = new HashSet<Zamowieny>();
        }
    
        public int IdRabatu { get; set; }
        public string OpisRabatu { get; set; }
        public int WysokoscRabatu { get; set; }
    
        public virtual ICollection<Zamowieny> Zamowienies { get; set; }
    }
}
