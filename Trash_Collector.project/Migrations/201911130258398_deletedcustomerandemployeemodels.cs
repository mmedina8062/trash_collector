namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedcustomerandemployeemodels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "ApplicationId" });
            DropIndex("dbo.Employees", new[] { "ApplicationId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Employees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ZipCode = c.Int(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PickupDay = c.String(),
                        AdditionalPickupDate = c.DateTime(nullable: false),
                        SuspendStartDate = c.DateTime(nullable: false),
                        SuspendEndDate = c.DateTime(nullable: false),
                        AccountBalance = c.Double(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Employees", "ApplicationId");
            CreateIndex("dbo.Customers", "ApplicationId");
            AddForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Customers", "ApplicationId", "dbo.AspNetUsers", "Id");
        }
    }
}
