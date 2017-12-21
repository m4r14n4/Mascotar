namespace WebMascotar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alert", "IdPet", c => c.Int(nullable: false));
            AddColumn("dbo.Alert", "IdPhoto", c => c.Int(nullable: false));
            AddColumn("dbo.Alert", "Image", c => c.Binary());
            AddColumn("dbo.User", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Password");
            DropColumn("dbo.Alert", "Image");
            DropColumn("dbo.Alert", "IdPhoto");
            DropColumn("dbo.Alert", "IdPet");
        }
    }
}
