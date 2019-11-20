namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedquestionmarktodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "AdditionalPickupDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "SuspendStartDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "SuspendEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "SuspendEndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "SuspendStartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "AdditionalPickupDate", c => c.DateTime(nullable: false));
        }
    }
}
