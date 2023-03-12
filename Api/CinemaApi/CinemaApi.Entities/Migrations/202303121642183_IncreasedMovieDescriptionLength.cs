namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncreasedMovieDescriptionLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String(maxLength: 3000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String(maxLength: 700));
        }
    }
}
