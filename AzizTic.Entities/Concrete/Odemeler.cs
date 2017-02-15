namespace AzizTic.Entities.Concrete
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Odemeler")]
    public partial class Odemeler : IEntity
    {
        public int Id { get; set; }

        public int KullaniciTipId { get; set; }

        public int OdemeTipId { get; set; }

        public bool OdemeOnay { get; set; }

        public bool OdemeDurum { get; set; }

        public virtual KullaniciTipleri KullaniciTipleri { get; set; }

        public virtual OdemeTipleri OdemeTipleri { get; set; }
    }
}
