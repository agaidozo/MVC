namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableInMoviesTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Retails", newName: "Rentals");
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
            RenameTable(name: "dbo.Rentals", newName: "Retails");
        }
    }
}
