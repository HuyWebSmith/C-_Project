namespace TH.lab02_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbnewstudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        MaNganh = c.String(nullable: false, maxLength: 128),
                        TenNganh = c.String(),
                    })
                .PrimaryKey(t => t.MaNganh);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                        HoTen = c.String(),
                        Sdt = c.String(),
                        ChuyenNganh = c.String(),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.Faculty");
        }
    }
}
