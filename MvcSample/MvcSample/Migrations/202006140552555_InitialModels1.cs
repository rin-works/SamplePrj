namespace MvcSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DepartmentId", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Department", c => c.String());
            DropColumn("dbo.Users", "DepartmentId");
        }
    }
}
