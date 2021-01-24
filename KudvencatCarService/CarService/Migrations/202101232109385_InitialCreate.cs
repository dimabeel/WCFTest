namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.String(),
                        Model = c.String(),
                        YearOfProduction = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Car");
        }
    }
}
