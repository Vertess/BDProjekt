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
    
    public partial class RealizacjeReklamacji
    {
        public RealizacjeReklamacji()
        {
            this.Reklamacjas = new HashSet<Reklamacja>();
        }
    
        public int IdRealizacji { get; set; }
        public string Opis { get; set; }
    
        public virtual ICollection<Reklamacja> Reklamacjas { get; set; }
    }
}
