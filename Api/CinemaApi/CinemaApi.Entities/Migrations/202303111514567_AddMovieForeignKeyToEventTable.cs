namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieForeignKeyToEventTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Events", "MovieId");
            AddForeignKey("dbo.Events", "MovieId", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "MovieId", "dbo.Movies");
            DropIndex("dbo.Events", new[] { "MovieId" });
        }
    }
}
