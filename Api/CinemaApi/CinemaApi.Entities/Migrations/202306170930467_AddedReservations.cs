namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReservations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                {
                    Id = c.Int(nullable: false),
                    CustomerName = c.String(),
                    CustomerPhone = c.String(),
                    CustomerEmail = c.String(),
                    EventId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
        }
    }
}
