namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTimeMovieNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Added", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Added", c => c.DateTime(nullable: false));
        }
    }
}
