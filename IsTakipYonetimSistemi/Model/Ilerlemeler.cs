//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipYonetimSistemi.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ilerlemeler
    {
        public int Id { get; set; }
        public int Proje_Id { get; set; }
        public int Ilerleme_Yuzdesi { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Proejeler Proejeler { get; set; }
    }
}