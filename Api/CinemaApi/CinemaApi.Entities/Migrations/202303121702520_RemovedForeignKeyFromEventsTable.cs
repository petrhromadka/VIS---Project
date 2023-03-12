namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedForeignKeyFromEventsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "MovieId", "dbo.Movies");
            DropIndex("dbo.Events", new[] { "MovieId" });
            RenameColumn(table: "dbo.Events", name: "MovieId", newName: "Movie_Id");
            AlterColumn("dbo.Events", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Events", "Movie_Id");
            AddForeignKey("dbo.Events", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Events", new[] { "Movie_Id" });
            AlterColumn("dbo.Events", "Movie_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Events", name: "Movie_Id", newName: "MovieId");
            CreateIndex("dbo.Events", "MovieId");
            AddForeignKey("dbo.Events", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
