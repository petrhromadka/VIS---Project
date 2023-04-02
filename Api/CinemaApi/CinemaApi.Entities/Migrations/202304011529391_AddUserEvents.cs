namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.UserEvents",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Event_Id)
                .Index(t => t.User_Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.Users", t => t.User_Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEvents", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserEvents", "Event_Id", "dbo.Events");
            DropIndex("dbo.UserEvents", new[] { "User_Id" });
            DropIndex("dbo.UserEvents", new[] { "Event_Id" });
            DropTable("dbo.UserEvents");
        }
    }
}
