namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Sex", c => c.Byte(nullable: false));
        }
    }
}
