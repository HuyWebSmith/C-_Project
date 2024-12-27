using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public class StudentDBContext : DbContext
    {
        // Your context has been configured to use a 'StudentDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Entities.StudentDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentDBContext' 
        // connection string in the application configuration file.
        public StudentDBContext()
            : base("name=StudentDBContext")
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Faculty> Facultys { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
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