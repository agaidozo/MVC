namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTableMovie : DbMigration
    {
        public override void Up()
        {
            Sql("TRUNCATE TABLE Movies");
            Sql("DROP TABLE Movies");
        }
        
        public override void Down()
        {
        }
    }
}
