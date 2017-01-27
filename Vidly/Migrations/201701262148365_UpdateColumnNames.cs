namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnNames : DbMigration
    {
        public override void Up()
        {
            
            
            RenameColumn(table: "dbo.Retails", name: "CustomerId", newName: "Customer_Id");
            RenameIndex(table: "dbo.Retails", name: "IX_CustomerId", newName: "IX_Customer_Id");
            DropPrimaryKey("dbo.Retails");
            AlterColumn("dbo.Retails", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Retails", "DateReturned", c => c.DateTime());
            
            AddPrimaryKey("dbo.Retails", "Id");
           
          
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Retails", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Retails", new[] { "Movie_Id" });
            DropPrimaryKey("dbo.Retails");
            AlterColumn("dbo.Retails", "Movie_Id", c => c.Int());
            AlterColumn("dbo.Retails", "DateReturned", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Retails", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Retails", "Id");
            RenameIndex(table: "dbo.Retails", name: "IX_Customer_Id", newName: "IX_CustomerId");
            RenameColumn(table: "dbo.Retails", name: "Customer_Id", newName: "CustomerId");
            CreateIndex("dbo.Retails", "Movie_Id");
            AddForeignKey("dbo.Retails", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
