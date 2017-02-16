namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanicilar")]
    public partial class Kullanicilar : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            KullaniciTipleri = new HashSet<KullaniciTipleri>();
    
            Roller = new HashSet<Roller>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciSoyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        public string Sifre { get; set; }

        public bool TelefonOnay { get; set; }

        [Required]
        [StringLength(50)]
        public string TelefonNo { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public bool EmailOnay { get; set; }

        [Column(TypeName = "image")]
        public byte[] KullaniciResim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciTipleri> KullaniciTipleri { get; set; }

        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roller> Roller { get; set; }
    }
}
