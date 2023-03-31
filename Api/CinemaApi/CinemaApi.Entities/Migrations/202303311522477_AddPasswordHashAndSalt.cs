namespace CinemaApi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPasswordHashAndSalt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PasswordHash", c => c.Binary(nullable: false));
            AddColumn("dbo.Users", "PasswordSalt", c => c.Binary(nullable: false));
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Users", "PasswordSalt");
            DropColumn("dbo.Users", "PasswordHash");
        }
    }
}
