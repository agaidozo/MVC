namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateReturnedAndDateRented : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Retails", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Retails", new[] { "Customer_Id" });
            DropColumn("dbo.Retails", "CustomerId");
            RenameColumn(table: "dbo.Retails", name: "Customer_Id", newName: "CustomerId");
            AddColumn("dbo.Retails", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.Retails", "DateReturned", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Retails", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Retails", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Retails", "CustomerId");
            AddForeignKey("dbo.Retails", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.Retails", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Retails", "MovieId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Retails", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Retails", new[] { "CustomerId" });
            AlterColumn("dbo.Retails", "CustomerId", c => c.Int());
            AlterColumn("dbo.Retails", "CustomerId", c => c.Byte(nullable: false));
            DropColumn("dbo.Retails", "DateReturned");
            DropColumn("dbo.Retails", "DateRented");
            RenameColumn(table: "dbo.Retails", name: "CustomerId", newName: "Customer_Id");
            AddColumn("dbo.Retails", "CustomerId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Retails", "Customer_Id");
            AddForeignKey("dbo.Retails", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
