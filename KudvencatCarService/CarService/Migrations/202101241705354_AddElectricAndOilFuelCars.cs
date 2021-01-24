namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddElectricAndOilFuelCars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "EngineType", c => c.Int(nullable: false));
            AddColumn("dbo.Car", "RangeInKilometers", c => c.Int());
            AddColumn("dbo.Car", "EngineСС", c => c.Int());
            AddColumn("dbo.Car", "EnginePower", c => c.Int());
            AddColumn("dbo.Car", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Discriminator");
            DropColumn("dbo.Car", "EnginePower");
            DropColumn("dbo.Car", "EngineСС");
            DropColumn("dbo.Car", "RangeInKilometers");
            DropColumn("dbo.Car", "EngineType");
        }
    }
}
