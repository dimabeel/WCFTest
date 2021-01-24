namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtimestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Timestamp");
        }
    }
}
