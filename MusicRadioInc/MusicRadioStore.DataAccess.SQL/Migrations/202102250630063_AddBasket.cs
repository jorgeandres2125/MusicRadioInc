namespace MusicRadioStore.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasket : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BasketItems", newName: "BasketItem");
            RenameTable(name: "dbo.Baskets", newName: "Basket");
            DropForeignKey("dbo.BasketItems", "AlbumSet_Id", "dbo.AlbumSet");
            DropIndex("dbo.BasketItem", new[] { "AlbumSet_Id" });
            DropColumn("dbo.BasketItem", "AlbumSetId");
            RenameColumn(table: "dbo.BasketItem", name: "AlbumSet_Id", newName: "AlbumSetId");
            AlterColumn("dbo.BasketItem", "AlbumSetId", c => c.Int(nullable: false));
            AlterColumn("dbo.BasketItem", "AlbumSetId", c => c.Int(nullable: false));
            CreateIndex("dbo.BasketItem", "AlbumSetId");
            AddForeignKey("dbo.BasketItem", "AlbumSetId", "dbo.AlbumSet", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BasketItem", "AlbumSetId", "dbo.AlbumSet");
            DropIndex("dbo.BasketItem", new[] { "AlbumSetId" });
            AlterColumn("dbo.BasketItem", "AlbumSetId", c => c.Int());
            AlterColumn("dbo.BasketItem", "AlbumSetId", c => c.String());
            RenameColumn(table: "dbo.BasketItem", name: "AlbumSetId", newName: "AlbumSet_Id");
            AddColumn("dbo.BasketItem", "AlbumSetId", c => c.String());
            CreateIndex("dbo.BasketItem", "AlbumSet_Id");
            AddForeignKey("dbo.BasketItems", "AlbumSet_Id", "dbo.AlbumSet", "Id");
            RenameTable(name: "dbo.Basket", newName: "Baskets");
            RenameTable(name: "dbo.BasketItem", newName: "BasketItems");
        }
    }
}
