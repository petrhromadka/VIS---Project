﻿namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreFromEnumToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
        }
    }
}
