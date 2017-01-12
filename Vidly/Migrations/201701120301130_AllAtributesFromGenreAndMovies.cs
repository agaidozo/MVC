namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllAtributesFromGenreAndMovies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AddColumn("dbo.Movies", "Release", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Added", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "StockNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "StockNumber");
            DropColumn("dbo.Movies", "Added");
            DropColumn("dbo.Movies", "Release");
            AddPrimaryKey("dbo.Genres", "Id");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
