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
    
    public partial class Calisanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calisanlar()
        {
            this.Proje_Calisanlari = new HashSet<Proje_Calisanlari>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Cinsiyet { get; set; }
        public int Pozisyon_Id { get; set; }
        public int Departman_Id { get; set; }
    
        public virtual Departmanlar Departmanlar { get; set; }
        public virtual Pozisyonlar Pozisyonlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proje_Calisanlari> Proje_Calisanlari { get; set; }
    }
}