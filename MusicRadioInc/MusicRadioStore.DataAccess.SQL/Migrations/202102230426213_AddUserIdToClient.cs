namespace MusicRadioStore.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "UserId");
        }
    }
}
