namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForengKey : DbMigration
    {
        public override void Up()
        {
            Sql("DROP TABLE Genres");
            //AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            //DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
        }
    }
}
