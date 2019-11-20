namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedboolconfrimpickuptocustomerclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ConfirmPickedup", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ZipCode", c => c.String());
            DropColumn("dbo.Customers", "ConfirmPickedup");
        }
    }
}
