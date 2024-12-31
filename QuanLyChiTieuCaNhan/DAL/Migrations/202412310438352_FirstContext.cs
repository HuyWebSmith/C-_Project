namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budget",
                c => new
                    {
                        BudgetID = c.String(nullable: false, maxLength: 128),
                        AmountLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        UserID = c.String(maxLength: 128),
                        CategoryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BudgetID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        CategoryType = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionID = c.String(nullable: false, maxLength: 128),
                        TransactionName = c.String(nullable: false, maxLength: 100),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        UserID = c.String(maxLength: 128),
                        CategoryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        FullName = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 15),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        GoalID = c.String(nullable: false, maxLength: 128),
                        GoalName = c.String(nullable: false, maxLength: 100),
                        TargetAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GoalID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportID = c.String(nullable: false, maxLength: 128),
                        StartAReportDate = c.DateTime(nullable: false),
                        EndAReportDate = c.DateTime(nullable: false),
                        TotalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReportDetails = c.String(),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaction", "UserID", "dbo.User");
            DropForeignKey("dbo.Report", "UserID", "dbo.User");
            DropForeignKey("dbo.Goals", "UserID", "dbo.User");
            DropForeignKey("dbo.Categories", "UserID", "dbo.User");
            DropForeignKey("dbo.Budget", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Budget", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Report", new[] { "UserID" });
            DropIndex("dbo.Goals", new[] { "UserID" });
            DropIndex("dbo.Transaction", new[] { "CategoryID" });
            DropIndex("dbo.Transaction", new[] { "UserID" });
            DropIndex("dbo.Categories", new[] { "UserID" });
            DropIndex("dbo.Budget", new[] { "CategoryID" });
            DropIndex("dbo.Budget", new[] { "UserID" });
            DropTable("dbo.Report");
            DropTable("dbo.Goals");
            DropTable("dbo.User");
            DropTable("dbo.Transaction");
            DropTable("dbo.Categories");
            DropTable("dbo.Budget");
        }
    }
}
