namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateTime = c.DateTime(nullable: false),
                    Price = c.Int(nullable: false),
                    Hall_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Halls", t => t.Hall_Id)
                .Index(t => t.Hall_Id);

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

            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 50),
                    Genre = c.String(nullable: false),
                    Duration = c.Int(nullable: false),
                    Rating = c.Int(),
                    Director = c.String(maxLength: 50),
                    Description = c.String(maxLength: 3000),
                    Thumbnail = c.String(maxLength: 200),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Events", "Hall_Id", "dbo.Halls");
            DropForeignKey("dbo.Seats", "Hall_Id", "dbo.Halls");
            DropIndex("dbo.Seats", new[] { "Hall_Id" });
            DropIndex("dbo.Events", new[] { "Hall_Id" });
            DropTable("dbo.Movies");
            DropTable("dbo.Seats");
            DropTable("dbo.Halls");
            DropTable("dbo.Events");
        }
    }
}
