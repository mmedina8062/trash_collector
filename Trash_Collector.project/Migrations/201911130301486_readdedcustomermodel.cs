namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readdedcustomermodel : DbMigration
    {
        public override void Up()
        {
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
                        ApplicationId = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Customers");
        }
    }
}
