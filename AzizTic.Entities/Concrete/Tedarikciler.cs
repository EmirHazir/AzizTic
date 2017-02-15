namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tedarikciler")]
    public partial class Tedarikciler : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tedarikciler()
        {
            Urunler = new HashSet<Urunler>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string FirmaAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string YetkiliAd { get; set; }

        [Required]
        [StringLength(100)]
        public string YetkiliEmail { get; set; }

        [Required]
        [StringLength(700)]
        public string FirmaAdres { get; set; }

        [Required]
        [StringLength(50)]
        public string FirmaSehir { get; set; }

        [Required]
        [StringLength(50)]
        public string FirmaTelefon { get; set; }

        [Required]
        [StringLength(50)]
        public string FirmaFax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
