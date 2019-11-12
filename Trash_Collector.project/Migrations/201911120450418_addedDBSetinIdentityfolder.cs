namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDBSetinIdentityfolder : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
