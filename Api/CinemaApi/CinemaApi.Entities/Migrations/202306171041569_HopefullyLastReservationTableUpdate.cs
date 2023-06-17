namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopefullyLastReservationTableUpdate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reservations", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reservations", "Id");
        }
    }
}
