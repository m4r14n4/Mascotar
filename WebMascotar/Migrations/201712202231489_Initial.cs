namespace WebMascotar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alert",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Mark1 = c.String(),
                        Mark2 = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Photo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        Name = c.String(),
                        Pet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pet", t => t.Pet_Id)
                .Index(t => t.Pet_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Zone = c.Int(nullable: false),
                        Pet1 = c.Int(nullable: false),
                        Pet2 = c.Int(nullable: false),
                        Pet3 = c.Int(nullable: false),
                        Zones_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Zone", t => t.Zones_ID)
                .Index(t => t.Zones_ID);
            
            CreateTable(
                "dbo.Zone",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Zones_ID", "dbo.Zone");
            DropForeignKey("dbo.Pet", "User_ID", "dbo.User");
            DropForeignKey("dbo.Photo", "Pet_Id", "dbo.Pet");
            DropIndex("dbo.User", new[] { "Zones_ID" });
            DropIndex("dbo.Photo", new[] { "Pet_Id" });
            DropIndex("dbo.Pet", new[] { "User_ID" });
            DropTable("dbo.Zone");
            DropTable("dbo.User");
            DropTable("dbo.Photo");
            DropTable("dbo.Pet");
            DropTable("dbo.Alert");
        }
    }
}
