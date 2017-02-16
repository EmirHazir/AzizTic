namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urunler")]
    public partial class Urunler: IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            Siparis_Detay = new HashSet<Siparis_Detay>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string UrunAdi { get; set; }

        public int TedarikciId { get; set; }

        public int YorumId { get; set; }

        public int KategoriId { get; set; }

        [Column(TypeName = "money")]
        public decimal UrunFiyati { get; set; }

        public int StokAdeti { get; set; }

        public decimal Indirim { get; set; }

        public bool UcretsizKargo { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] UrunResim { get; set; }

        [Required]
        [StringLength(100)]
        public string UrunKodu { get; set; }

        public int? UrunYildizi { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }

        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis_Detay> Siparis_Detay { get; set; }

        public virtual Tedarikciler Tedarikciler { get; set; }

        public virtual Yorumlar Yorumlar { get; set; }
    }
}
