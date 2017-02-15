namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KargoSirketleri")]
    public partial class KargoSirketleri : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KargoSirketleri()
        {
            Siparisler = new HashSet<Siparisler>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string KargoFirmaAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string TelefonNo { get; set; }

        [Required]
        [StringLength(150)]
        public string KargoYetkiliEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }
    }
}
