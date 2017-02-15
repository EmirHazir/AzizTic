namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OdemeTipleri")]
    public partial class OdemeTipleri : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OdemeTipleri()
        {
            Odemeler = new HashSet<Odemeler>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string OdemeTipAd { get; set; }

        [Required]
        [StringLength(150)]
        public string Aciklamasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odemeler> Odemeler { get; set; }
    }
}
