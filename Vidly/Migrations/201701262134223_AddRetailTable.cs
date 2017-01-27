namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRetailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Retails",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        CustomerId = c.Byte(nullable: false),
                        MovieId = c.Byte(nullable: false),
                        Customer_Id = c.Int(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Retails", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Retails", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Retails", new[] { "Movie_Id" });
            DropIndex("dbo.Retails", new[] { "Customer_Id" });
            DropTable("dbo.Retails");
        }
    }
}
