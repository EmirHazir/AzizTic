namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;


    [Table("SepetIcerik")]
    public partial class SepetIcerik : IEntity
    {
        public Urunler Urunler { get; set; }
        public int SepettekiUrunAdet { get; set; }
    }



    [Table("Sepet")]
    public partial class Sepet : IEntity
    {
        public Sepet()
        {
            SepetIcerikleri = new List<SepetIcerik>();
        }
        public List<SepetIcerik> SepetIcerikleri { get; set; }

        public decimal Toplam
        {
            get
            {
                return SepetIcerikleri.Sum(s => s.Urunler.UrunFiyati * s.SepettekiUrunAdet);
            }
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunId { get; set; }

        public int Adet { get; set; }

        public virtual Kullanicilar Kullanicilar { get; set; }

        public virtual Urunler Urunler { get; set; }
    }
}
