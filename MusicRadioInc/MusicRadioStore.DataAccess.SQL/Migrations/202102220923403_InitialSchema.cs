namespace MusicRadioStore.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlbumSet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Direction = c.String(nullable: false, maxLength: 500),
                        Phone = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseDatail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AlbumSetId = c.Int(nullable: false),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        PurchaseId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlbumSet", t => t.AlbumSetId, cascadeDelete: true)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Purchase", t => t.PurchaseId, cascadeDelete: true)
                .Index(t => t.AlbumSetId)
                .Index(t => t.ClientId)
                .Index(t => t.PurchaseId);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderStatus = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SongSet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AlbumSetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlbumSet", t => t.AlbumSetId, cascadeDelete: true)
                .Index(t => t.AlbumSetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SongSet", "AlbumSetId", "dbo.AlbumSet");
            DropForeignKey("dbo.PurchaseDatail", "PurchaseId", "dbo.Purchase");
            DropForeignKey("dbo.PurchaseDatail", "ClientId", "dbo.Client");
            DropForeignKey("dbo.PurchaseDatail", "AlbumSetId", "dbo.AlbumSet");
            DropIndex("dbo.SongSet", new[] { "AlbumSetId" });
            DropIndex("dbo.PurchaseDatail", new[] { "PurchaseId" });
            DropIndex("dbo.PurchaseDatail", new[] { "ClientId" });
            DropIndex("dbo.PurchaseDatail", new[] { "AlbumSetId" });
            DropTable("dbo.SongSet");
            DropTable("dbo.Purchase");
            DropTable("dbo.PurchaseDatail");
            DropTable("dbo.Client");
            DropTable("dbo.AlbumSet");
        }
    }
}
