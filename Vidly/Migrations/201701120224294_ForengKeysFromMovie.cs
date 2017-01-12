namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ForengKeysFromMovie : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE Movies SET GenreId=1 WHERE Id=3");
            //Sql("UPDATE Movies SET GenreId=2 WHERE Id=4");
            //Sql("UPDATE Movies SET GenreId=2 WHERE Id=5");
            //Sql("UPDATE Movies SET GenreId=3 WHERE Id=6");
            //Sql("UPDATE Movies SET GenreId=4 WHERE Id=7");
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
