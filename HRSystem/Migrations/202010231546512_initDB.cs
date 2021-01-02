namespace HRSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID, cascadeDelete: true)
                .Index(t => t.Country_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Gender_id = c.Int(nullable: false),
                        Country_id = c.Int(nullable: false),
                        City_id = c.Int(nullable: false),
                        Address = c.String(),
                        Email = c.String(nullable: false),
                        salary = c.Double(nullable: false),
                        ExpectedSalary = c.Double(nullable: false),
                        Department_id = c.Int(nullable: false),
                        hireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_id, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_id, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.Department_id, cascadeDelete: true)
                .Index(t => t.Country_id)
                .Index(t => t.City_id)
                .Index(t => t.Department_id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Employees", "Department_id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "City_id", "dbo.Cities");
            DropForeignKey("dbo.Employees", "Country_id", "dbo.Countries");
            DropIndex("dbo.Employees", new[] { "Department_id" });
            DropIndex("dbo.Employees", new[] { "City_id" });
            DropIndex("dbo.Employees", new[] { "Country_id" });
            DropIndex("dbo.Cities", new[] { "Country_ID" });
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
