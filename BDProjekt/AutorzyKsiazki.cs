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
    
    public partial class AutorzyKsiazki
    {
        public int IDAutorzyKsiazki { get; set; }
        public int Autor_IdAutora { get; set; }
        public int IdKsiazka_IdKsiazki { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual Ksiazka Ksiazka { get; set; }
    }
}
