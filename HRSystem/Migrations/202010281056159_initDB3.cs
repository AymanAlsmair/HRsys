namespace HRSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Phone", c => c.Int(nullable: false));
        }
    }
}
