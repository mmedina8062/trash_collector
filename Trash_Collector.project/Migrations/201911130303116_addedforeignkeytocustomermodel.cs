namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeytocustomermodel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Customers", "ApplicationId");
            RenameColumn(table: "dbo.Customers", name: "ApplicationUser_Id", newName: "ApplicationId");
            AlterColumn("dbo.Customers", "ApplicationId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "ApplicationId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "ApplicationId" });
            AlterColumn("dbo.Customers", "ApplicationId", c => c.String());
            RenameColumn(table: "dbo.Customers", name: "ApplicationId", newName: "ApplicationUser_Id");
            AddColumn("dbo.Customers", "ApplicationId", c => c.String());
            CreateIndex("dbo.Customers", "ApplicationUser_Id");
        }
    }
}
