namespace Trash_Collector.project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeytoemployeemodel : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "ApplicationId" });
            DropTable("dbo.Employees");
        }
    }
}
