namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserEntities : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.UserEvents", "Seat_Id", "dbo.Seats");
            DropForeignKey("dbo.UserEvents", "User_Id", "dbo.Users");
            DropIndex("dbo.UserEvents", new[] { "Event_Id" });
            DropIndex("dbo.UserEvents", new[] { "Seat_Id" });
            DropIndex("dbo.UserEvents", new[] { "User_Id" });
            DropTable("dbo.UserEvents");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        PasswordHash = c.Binary(nullable: false),
                        PasswordSalt = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event_Id = c.Int(),
                        Seat_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.UserEvents", "User_Id");
            CreateIndex("dbo.UserEvents", "Seat_Id");
            CreateIndex("dbo.UserEvents", "Event_Id");
            AddForeignKey("dbo.UserEvents", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UserEvents", "Seat_Id", "dbo.Seats", "Id");
            AddForeignKey("dbo.UserEvents", "Event_Id", "dbo.Events", "Id");
        }
    }
}
