namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentDBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ClassID = c.String(nullable: false, maxLength: 128),
                        ClassName = c.String(nullable: false, maxLength: 30),
                        FacultyID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClassID)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        FacultyID = c.String(nullable: false, maxLength: 128),
                        FacultyName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Sex = c.Byte(nullable: false),
                        Birth = c.String(),
                        Address = c.String(maxLength: 200),
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 15),
                        ClassID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Student", t => t.ClassID)
                .ForeignKey("dbo.Class", t => t.ClassID)
                .Index(t => t.ClassID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ClassID", "dbo.Class");
            DropForeignKey("dbo.Student", "ClassID", "dbo.Student");
            DropForeignKey("dbo.Class", "FacultyID", "dbo.Faculty");
            DropIndex("dbo.Student", new[] { "ClassID" });
            DropIndex("dbo.Class", new[] { "FacultyID" });
            DropTable("dbo.Student");
            DropTable("dbo.Faculty");
            DropTable("dbo.Class");
        }
    }
}
