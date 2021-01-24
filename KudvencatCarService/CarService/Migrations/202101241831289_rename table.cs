namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renametable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cars", newName: "Car");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Car", newName: "Cars");
        }
    }
}
