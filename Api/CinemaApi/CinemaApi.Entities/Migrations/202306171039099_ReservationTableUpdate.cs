namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservationTableUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "CustomerName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Reservations", "CustomerPhone", c => c.String(nullable: false, maxLength: 64));
            AlterColumn("dbo.Reservations", "CustomerEmail", c => c.String(maxLength: 512));
            AlterColumn("dbo.Reservations", "SeatReservations", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "SeatReservations", c => c.String());
            AlterColumn("dbo.Reservations", "CustomerEmail", c => c.String());
            AlterColumn("dbo.Reservations", "CustomerPhone", c => c.String());
            AlterColumn("dbo.Reservations", "CustomerName", c => c.String());
        }
    }
}
