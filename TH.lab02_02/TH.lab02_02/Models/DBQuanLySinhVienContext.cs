using System;
using System.Data.Entity;
using System.Linq;

namespace TH.lab02_02.Models
{
    public class DBQuanLySinhVienContext : DbContext
    {
        // Your context has been configured to use a 'DBQuanLySinhVienContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TH.lab02_02.Models.DBQuanLySinhVienContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBQuanLySinhVienContext' 
        // connection string in the application configuration file.
        public DBQuanLySinhVienContext()
            : base("name=DBQuanLySinhVienContext")
        {
        }
        public virtual DbSet<Faculty> faculty { get; set; }
        public virtual DbSet<Student> student { get; set; }
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