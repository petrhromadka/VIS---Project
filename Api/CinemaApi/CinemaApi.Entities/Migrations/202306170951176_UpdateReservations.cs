namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReservations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "TotalPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "SeatReservations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "SeatReservations");
            DropColumn("dbo.Reservations", "TotalPrice");
        }
    }
}
