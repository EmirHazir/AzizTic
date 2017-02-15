namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategoriler")]
    public partial class Kategoriler : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategoriler()
        {
            Urunler = new HashSet<Urunler>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string KategoriAdi { get; set; }

        public int AltKategoriId { get; set; }

        [Required]
        [StringLength(250)]
        public string Aciklama { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] KategoriResim { get; set; }

        public virtual Alt_Kategoriler Alt_Kategoriler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
