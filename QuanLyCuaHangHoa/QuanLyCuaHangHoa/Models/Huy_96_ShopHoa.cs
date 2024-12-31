using System;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHangHoa.Models
{
    public class Huy__96__ShopHoa : DbContext
    {
        // Your context has been configured to use a 'Huy__96__ShopHoa' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuanLyCuaHangHoa.Models.Huy__96__ShopHoa' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Huy__96__ShopHoa' 
        // connection string in the application configuration file.
        public Huy__96__ShopHoa()
            : base("name=Huy_96_ShopHoa")
        {
        }
        public virtual DbSet<Huy_96_DanhSachCuaHang> huy_96__DanhSachCuaHangs { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}