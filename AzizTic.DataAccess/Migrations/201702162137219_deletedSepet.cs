namespace AzizTic.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedSepet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sepet", "Kullanicilar_Id", "dbo.Kullanicilar");
            DropForeignKey("dbo.SepetIcerik", "Urunler_Id", "dbo.Urunler");
            DropForeignKey("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" }, "dbo.Sepet");
            DropForeignKey("dbo.Sepet", "Urunler_Id", "dbo.Urunler");
            DropIndex("dbo.Sepet", new[] { "Kullanicilar_Id" });
            DropIndex("dbo.Sepet", new[] { "Urunler_Id" });
            DropIndex("dbo.SepetIcerik", new[] { "Urunler_Id" });
            DropIndex("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" });
            DropTable("dbo.Sepet");
            DropTable("dbo.SepetIcerik");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => new { t.KullaniciId, t.UrunId });
            
            CreateIndex("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" });
            CreateIndex("dbo.SepetIcerik", "Urunler_Id");
            CreateIndex("dbo.Sepet", "Urunler_Id");
            CreateIndex("dbo.Sepet", "Kullanicilar_Id");
            AddForeignKey("dbo.Sepet", "Urunler_Id", "dbo.Urunler", "Id");
            AddForeignKey("dbo.SepetIcerik", new[] { "Sepet_KullaniciId", "Sepet_UrunId" }, "dbo.Sepet", new[] { "KullaniciId", "UrunId" });
            AddForeignKey("dbo.SepetIcerik", "Urunler_Id", "dbo.Urunler", "Id");
            AddForeignKey("dbo.Sepet", "Kullanicilar_Id", "dbo.Kullanicilar", "Id");
        }
    }
}
