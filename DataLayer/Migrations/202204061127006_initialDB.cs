namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lists",
                c => new
                    {
                        ListID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        MakerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ListID);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        PartnerID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ListID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartnerID)
                .ForeignKey("dbo.Lists", t => t.ListID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ListID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        ListID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 200),
                        Date = c.DateTime(nullable: false),
                        DoneDate = c.DateTime(),
                        IsDone = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.Lists", t => t.ListID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ListID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "UserID", "dbo.Users");
            DropForeignKey("dbo.Tasks", "ListID", "dbo.Lists");
            DropForeignKey("dbo.Partners", "UserID", "dbo.Users");
            DropForeignKey("dbo.Partners", "ListID", "dbo.Lists");
            DropIndex("dbo.Tasks", new[] { "UserID" });
            DropIndex("dbo.Tasks", new[] { "ListID" });
            DropIndex("dbo.Partners", new[] { "ListID" });
            DropIndex("dbo.Partners", new[] { "UserID" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Users");
            DropTable("dbo.Partners");
            DropTable("dbo.Lists");
        }
    }
}
