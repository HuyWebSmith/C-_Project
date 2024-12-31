namespace QuanLyCuaHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuaHangDBContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Huy_96_DanhSachCuaHang",
                c => new
                    {
                        MaCuaHang = c.String(nullable: false, maxLength: 128),
                        TenCuaHang = c.String(),
                        DiaChiCuaHang = c.String(),
                        SDT = c.String(),
                        Email = c.String(),
                        HoTenNhanVienQuanLy = c.String(),
                        SDTNhanVienQuanLy = c.String(),
                    })
                .PrimaryKey(t => t.MaCuaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Huy_96_DanhSachCuaHang");
        }
    }
}
