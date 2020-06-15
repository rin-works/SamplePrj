namespace MvcSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Users_ID", c => c.Int());
            CreateIndex("dbo.Departments", "Users_ID");
            AddForeignKey("dbo.Departments", "Users_ID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Users_ID", "dbo.Users");
            DropIndex("dbo.Departments", new[] { "Users_ID" });
            DropColumn("dbo.Departments", "Users_ID");
        }
    }
}
