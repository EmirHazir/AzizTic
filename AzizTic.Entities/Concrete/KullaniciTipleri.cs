namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciTipleri")]
    public partial class KullaniciTipleri : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KullaniciTipleri()
        {
            Odemeler = new HashSet<Odemeler>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciTipAdi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool IsActive { get; set; }

        public virtual Kullanicilar Kullanicilar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odemeler> Odemeler { get; set; }
    }
}
