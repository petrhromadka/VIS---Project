namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeatingPlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Halls",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 15),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Seats",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Row = c.Int(nullable: false),
                    SeatNumber = c.Int(nullable: false),
                    IsTaken = c.Boolean(nullable: false),
                    Hall_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Halls", t => t.Hall_Id)
                .Index(t => t.Hall_Id);

            AddColumn("dbo.Events", "Hall_Id", c => c.Int());
            AddColumn("dbo.UserEvents", "Seat_Id", c => c.Int());
            CreateIndex("dbo.Events", "Hall_Id");
            CreateIndex("dbo.UserEvents", "Seat_Id");
            AddForeignKey("dbo.Events", "Hall_Id", "dbo.Halls", "Id");
            AddForeignKey("dbo.UserEvents", "Seat_Id", "dbo.Seats", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEvents", "Seat_Id", "dbo.Seats");
            DropForeignKey("dbo.Events", "Hall_Id", "dbo.Halls");
            DropForeignKey("dbo.Seats", "Hall_Id", "dbo.Halls");
            DropIndex("dbo.UserEvents", new[] { "Seat_Id" });
            DropIndex("dbo.Seats", new[] { "Hall_Id" });
            DropIndex("dbo.Events", new[] { "Hall_Id" });
            DropColumn("dbo.UserEvents", "Seat_Id");
            DropColumn("dbo.Events", "Hall_Id");
            DropTable("dbo.Seats");
            DropTable("dbo.Halls");
        }
    }
}
