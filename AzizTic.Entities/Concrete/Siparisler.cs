namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Siparisler")]
    public partial class Siparisler : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            Siparis_Detay = new HashSet<Siparis_Detay>();
        }

        public int Id { get; set; }

        public int MusteriId { get; set; }

        public int KargoSirketId { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public DateTime TeslimTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal KargoUcreti { get; set; }

        [Required]
        [StringLength(50)]
        public string SiparisAdi { get; set; }

        [Required]
        [StringLength(250)]
        public string SiparisAdresi { get; set; }

        [Required]
        [StringLength(50)]
        public string SiparisSehir { get; set; }

        [Required]
        [StringLength(20)]
        public string SiparisPostaKodu { get; set; }

        public virtual KargoSirketleri KargoSirketleri { get; set; }

        public virtual Musteriler Musteriler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis_Detay> Siparis_Detay { get; set; }
    }
}
