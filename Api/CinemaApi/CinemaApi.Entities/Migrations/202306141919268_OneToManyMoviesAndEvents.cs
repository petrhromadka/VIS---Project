namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToManyMoviesAndEvents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Events", "Movie_Id");
            AddForeignKey("dbo.Events", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Events", new[] { "Movie_Id" });
            DropColumn("dbo.Events", "Movie_Id");
        }
    }
}
