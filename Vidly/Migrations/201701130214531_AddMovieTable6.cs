namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMovieTable6 : DbMigration
    {
        public override void Up()
        {
            Sql("DROP INDEX IX_Genre_Id ON Movies");
            Sql("ALTER TABLE Movies DROP CONSTRAINT [FK_dbo.Movies_dbo.Genres_Genre_Id]");
            Sql("ALTER TABLE Movies DROP COLUMN Genre_Id");
            
        }

        public override void Down()
        {
        }
    }
}
