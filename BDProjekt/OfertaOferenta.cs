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
    
    public partial class OfertaOferenta
    {
        public int IdOfertyOferenta { get; set; }
        public int CenaHurtowa { get; set; }
        public int Egzemplarz_IdEgzemplarza { get; set; }
        public int Oferent_IdOferenta { get; set; }
    
        public virtual Egzemplarz Egzemplarz { get; set; }
        public virtual Oferent Oferent { get; set; }
    }
}
