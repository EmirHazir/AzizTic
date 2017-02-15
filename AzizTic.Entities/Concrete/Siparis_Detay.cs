namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Siparis Detay")]
    public partial class Siparis_Detay : IEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiparisId { get; set; }

        [Column(TypeName = "money")]
        public decimal Fiyat { get; set; }

        public int Adet { get; set; }

        public decimal Indirim { get; set; }

        public virtual Siparisler Siparisler { get; set; }

        public virtual Urunler Urunler { get; set; }
    }
}
