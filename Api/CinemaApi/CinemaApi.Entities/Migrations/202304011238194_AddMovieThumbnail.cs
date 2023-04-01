namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieThumbnail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Thumbnail", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Thumbnail");
        }
    }
}
