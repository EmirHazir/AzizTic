

namespace AzizTic.DataAccess

{
    using System;
    using System.Data.Entity;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities.Concrete;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class ModelDBContext : DbContext
    {
        public ModelDBContext()
            : base("Baglanti")
        {
        }

        public virtual DbSet<Alt_Kategoriler> Alt_Kategoriler { get; set; }
        public virtual DbSet<KargoSirketleri> KargoSirketleri { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<KullaniciTipleri> KullaniciTipleri { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Odemeler> Odemeler { get; set; }
        public virtual DbSet<OdemeTipleri> OdemeTipleri { get; set; }
        public virtual DbSet<Roller> Roller { get; set; }

        public virtual DbSet<Siparis_Detay> Siparis_Detay { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikciler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Yorumlar> Yorumlar { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #region OnModel
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Alt_Kategoriler>()
        //        .HasMany(e => e.Kategoriler)
        //        .WithRequired(e => e.Alt_Kategoriler)
        //        .HasForeignKey(e => e.AltKategoriId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<KargoSirketleri>()
        //        .HasMany(e => e.Siparisler)
        //        .WithRequired(e => e.KargoSirketleri)
        //        .HasForeignKey(e => e.KargoSirketId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Kategoriler>()
        //        .HasMany(e => e.Urunler)
        //        .WithRequired(e => e.Kategoriler)
        //        .HasForeignKey(e => e.KategoriId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Kullanicilar>()
        //        .HasMany(e => e.KullaniciTipleri)
        //        .WithRequired(e => e.Kullanicilar)
        //        .HasForeignKey(e => e.KullaniciId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Kullanicilar>()
        //        .HasMany(e => e.Sepet)
        //        .WithRequired(e => e.Kullanicilar)
        //        .HasForeignKey(e => e.KullaniciId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Kullanicilar>()
        //        .HasMany(e => e.Roller)
        //        .WithMany(e => e.Kullanicilar)
        //        .Map(m => m.ToTable("Kullanici Rolleri").MapLeftKey("KullaniciId").MapRightKey("RolId"));

        //    modelBuilder.Entity<KullaniciTipleri>()
        //        .HasMany(e => e.Odemeler)
        //        .WithRequired(e => e.KullaniciTipleri)
        //        .HasForeignKey(e => e.KullaniciTipId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Musteriler>()
        //        .HasMany(e => e.Siparisler)
        //        .WithRequired(e => e.Musteriler)
        //        .HasForeignKey(e => e.MusteriId)
        //        .WillCascadeOnDelete(false);



        //    modelBuilder.Entity<OdemeTipleri>()
        //        .HasMany(e => e.Odemeler)
        //        .WithRequired(e => e.OdemeTipleri)
        //        .HasForeignKey(e => e.OdemeTipId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Siparis_Detay>()
        //        .Property(e => e.Fiyat)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Siparis_Detay>()
        //        .Property(e => e.Indirim)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<Siparisler>()
        //        .Property(e => e.KargoUcreti)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Siparisler>()
        //        .HasMany(e => e.Siparis_Detay)
        //        .WithRequired(e => e.Siparisler)
        //        .HasForeignKey(e => e.SiparisId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Tedarikciler>()
        //        .HasMany(e => e.Urunler)
        //        .WithRequired(e => e.Tedarikciler)
        //        .HasForeignKey(e => e.TedarikciId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Urunler>()
        //        .Property(e => e.UrunFiyati)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Urunler>()
        //        .Property(e => e.Indirim)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<Urunler>()
        //        .HasMany(e => e.Sepet)
        //        .WithRequired(e => e.Urunler)
        //        .HasForeignKey(e => e.UrunId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Urunler>()
        //        .HasMany(e => e.Siparis_Detay)
        //        .WithRequired(e => e.Urunler)
        //        .HasForeignKey(e => e.UrunId)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Yorumlar>()
        //        .HasMany(e => e.Urunler)
        //        .WithRequired(e => e.Yorumlar)
        //        .HasForeignKey(e => e.YorumId)
        //        .WillCascadeOnDelete(false);
        //} 
        #endregion
    }
}
