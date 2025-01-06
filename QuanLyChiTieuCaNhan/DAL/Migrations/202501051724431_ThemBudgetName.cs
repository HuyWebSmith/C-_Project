namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemBudgetName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Budget", "BudgetName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Budget", "BudgetName");
        }
    }
}
