namespace AzizTic.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulumCodeF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alt Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(nullable: false, maxLength: 150),
                        AltKategoriResim = c.Binary(nullable: false, storeType: "image"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 150),
                        AltKategoriId = c.Int(nullable: false),
                        Aciklama = c.String(nullable: false, maxLength: 250),
                        KategoriResim = c.Binary(nullable: false, storeType: "image"),
                        Alt_Kategoriler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alt Kategoriler", t => t.Alt_Kategoriler_Id)
                .Index(t => t.Alt_Kategoriler_Id);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 150),
                        TedarikciId = c.Int(nullable: false),
                        YorumId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        UrunFiyati = c.Decimal(nullable: false, storeType: "money"),
                        StokAdeti = c.Int(nullable: false),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UcretsizKargo = c.Boolean(nullable: false),
                        UrunResim = c.Binary(nullable: false, storeType: "image"),
                        UrunKodu = c.String(nullable: false, maxLength: 100),
                        UrunYildizi = c.Int(),
                        Kategoriler_Id = c.Int(),
                        Tedarikciler_Id = c.Int(),
                        Yorumlar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.Kategoriler_Id)
                .ForeignKey("dbo.Tedarikciler", t => t.Tedarikciler_Id)
                .ForeignKey("dbo.Yorumlar", t => t.Yorumlar_Id)
                .Index(t => t.Kategoriler_Id)
                .Index(t => t.Tedarikciler_Id)
                .Index(t => t.Yorumlar_Id);
            
            CreateTable(
                "dbo.Sepet",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        Kullanicilar_Id = c.Int(),
                        Urunler_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.KullaniciId, t.UrunId })
                .ForeignKey("dbo.Kullanicilar", t => t.Kullanicilar_Id)
                .ForeignKey("dbo.Urunler", t => t.Urunler_Id)
                .Index(t => t.Kullanicilar_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        KullaniciSoyadi = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 250),
                        TelefonOnay = c.Boolean(nullable: false),
                        TelefonNo = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        EmailOnay = c.Boolean(nullable: false),
                        KullaniciResim = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciTipleri",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        KullaniciTipAdi = c.String(nullable: false, maxLength: 50),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Kullanicilar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilar", t => t.Kullanicilar_Id)
                .Index(t => t.Kullanicilar_Id);
            
            CreateTable(
                "dbo.Odemeler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciTipId = c.Int(nullable: false),
                        OdemeTipId = c.Int(nullable: false),
                        OdemeOnay = c.Boolean(nullable: false),
                        OdemeDurum = c.Boolean(nullable: false),
                        KullaniciTipleri_Id = c.Int(),
                        OdemeTipleri_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KullaniciTipleri", t => t.KullaniciTipleri_Id)
                .ForeignKey("dbo.OdemeTipleri", t => t.OdemeTipleri_Id)
                .Index(t => t.KullaniciTipleri_Id)
                .Index(t => t.OdemeTipleri_Id);
            
            CreateTable(
                "dbo.OdemeTipleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OdemeTipAd = c.String(nullable: false, maxLength: 50),
                        Aciklamasi = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolAdi = c.String(nullable: false, maxLength: 50),
                        Aciklamasi = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SepetIcerik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SepettekiUrunAdet = c.Int(nullable: false),
                        Urunler_Id = c.Int(),
                        Sepet_KullaniciId = c.Int(),
                        Sepet_UrunId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunler", t => t.Urunler_Id)
                .ForeignKey("dbo.Sepet", t => new { t.Sepet_KullaniciId, t.Sepet_UrunId })
                .Index(t => t.Urunler_Id)
                .Index(t => new { t.Sepet_KullaniciId, t.Sepet_UrunId });
            
            CreateTable(
                "dbo.Siparis Detay",
                c => new
                    {
                        UrunId = c.Int(nullable: false),
                        SiparisId = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, storeType: "money"),
                        Adet = c.Int(nullable: false),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Siparisler_Id = c.Int(),
                        Urunler_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.UrunId, t.SiparisId })
                .ForeignKey("dbo.Siparisler", t => t.Siparisler_Id)
                .ForeignKey("dbo.Urunler", t => t.Urunler_Id)
                .Index(t => t.Siparisler_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        KargoSirketId = c.Int(nullable: false),
                        SiparisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        KargoUcreti = c.Decimal(nullable: false, storeType: "money"),
                        SiparisAdi = c.String(nullable: false, maxLength: 50),
                        SiparisAdresi = c.String(nullable: false, maxLength: 250),
                        SiparisSehir = c.String(nullable: false, maxLength: 50),
                        SiparisPostaKodu = c.String(nullable: false, maxLength: 20),
                        KargoSirketleri_Id = c.Int(),
                        Musteriler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KargoSirketleri", t => t.KargoSirketleri_Id)
                .ForeignKey("dbo.Musteriler", t => t.Musteriler_Id)
                .Index(t => t.KargoSirketleri_Id)
                .Index(t => t.Musteriler_Id);
            
            CreateTable(
                "dbo.KargoSirketleri",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        KargoFirmaAdi = c.String(nullable: false, maxLength: 50),
                        TelefonNo = c.String(nullable: false, maxLength: 50),
                        KargoYetkiliEmail = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(maxLength: 50),
                        MusteriSoyad = c.String(maxLength: 50),
                        MusteriAdres = c.String(maxLength: 700),
                        MusteriSehir = c.String(maxLength: 50),
                        MusteriTelefon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tedarikciler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 500),
                        YetkiliAd = c.String(nullable: false, maxLength: 50),
                        YetkiliEmail = c.String(nullable: false, maxLength: 100),
                        FirmaAdres = c.String(nullable: false, maxLength: 700),
                        FirmaSehir = c.String(nullable: false, maxLength: 50),
                        FirmaTelefon = c.String(nullable: false, maxLength: 50),
                        FirmaFax = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        YorumIcerik = c.String(nullable: false, maxLength: 140),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RollerKullanicilar",
                c => new
                    {
                        Roller_Id = c.Int(nullable: false),
                        Kullanicilar_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roller_Id, t.Kullanicilar_Id })
                .ForeignKey("dbo.Roller", t => t.Roller_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicilar", t => t.Kullanicilar_Id, cascadeDelete: true)
                .Index(t => t.Roller_Id)
                .Index(t => t.Kullanicilar_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "Yorumlar_Id", "dbo.Yorumlar");
            DropForeignKey("dbo.Urunler", "Tedarikciler_Id", "dbo.Tedarikciler");
            DropForeignKey("dbo.Siparis Detay", "Urunler_Id", "dbo.Urunler");
            DropForeignKey("dbo.Siparis Detay", "Siparisler_Id", "dbo.Siparisler");
            DropForeignKey("dbo.Siparisler", "Musteriler_Id", "dbo.Musteriler");
            DropForeignKey("dbo.Siparisler", "KargoSirketleri_Id", "dbo.KargoSirketleri");
            DropForeignKey("dbo.Sepet", "Urunler_Id", "dbo.Urunler");
            DropForeignKey("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" }, "dbo.Sepet");
            DropForeignKey("dbo.SepetIcerik", "Urunler_Id", "dbo.Urunler");
            DropForeignKey("dbo.Sepet", "Kullanicilar_Id", "dbo.Kullanicilar");
            DropForeignKey("dbo.RollerKullanicilar", "Kullanicilar_Id", "dbo.Kullanicilar");
            DropForeignKey("dbo.RollerKullanicilar", "Roller_Id", "dbo.Roller");
            DropForeignKey("dbo.Odemeler", "OdemeTipleri_Id", "dbo.OdemeTipleri");
            DropForeignKey("dbo.Odemeler", "KullaniciTipleri_Id", "dbo.KullaniciTipleri");
            DropForeignKey("dbo.KullaniciTipleri", "Kullanicilar_Id", "dbo.Kullanicilar");
            DropForeignKey("dbo.Urunler", "Kategoriler_Id", "dbo.Kategoriler");
            DropForeignKey("dbo.Kategoriler", "Alt_Kategoriler_Id", "dbo.Alt Kategoriler");
            DropIndex("dbo.RollerKullanicilar", new[] { "Kullanicilar_Id" });
            DropIndex("dbo.RollerKullanicilar", new[] { "Roller_Id" });
            DropIndex("dbo.Siparisler", new[] { "Musteriler_Id" });
            DropIndex("dbo.Siparisler", new[] { "KargoSirketleri_Id" });
            DropIndex("dbo.Siparis Detay", new[] { "Urunler_Id" });
            DropIndex("dbo.Siparis Detay", new[] { "Siparisler_Id" });
            DropIndex("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" });
            DropIndex("dbo.SepetIcerik", new[] { "Urunler_Id" });
            DropIndex("dbo.Odemeler", new[] { "OdemeTipleri_Id" });
            DropIndex("dbo.Odemeler", new[] { "KullaniciTipleri_Id" });
            DropIndex("dbo.KullaniciTipleri", new[] { "Kullanicilar_Id" });
            DropIndex("dbo.Sepet", new[] { "Urunler_Id" });
            DropIndex("dbo.Sepet", new[] { "Kullanicilar_Id" });
            DropIndex("dbo.Urunler", new[] { "Yorumlar_Id" });
            DropIndex("dbo.Urunler", new[] { "Tedarikciler_Id" });
            DropIndex("dbo.Urunler", new[] { "Kategoriler_Id" });
            DropIndex("dbo.Kategoriler", new[] { "Alt_Kategoriler_Id" });
            DropTable("dbo.RollerKullanicilar");
            DropTable("dbo.Yorumlar");
            DropTable("dbo.Tedarikciler");
            DropTable("dbo.Musteriler");
            DropTable("dbo.KargoSirketleri");
            DropTable("dbo.Siparisler");
            DropTable("dbo.Siparis Detay");
            DropTable("dbo.SepetIcerik");
            DropTable("dbo.Roller");
            DropTable("dbo.OdemeTipleri");
            DropTable("dbo.Odemeler");
            DropTable("dbo.KullaniciTipleri");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Sepet");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Alt Kategoriler");
        }
    }
}
