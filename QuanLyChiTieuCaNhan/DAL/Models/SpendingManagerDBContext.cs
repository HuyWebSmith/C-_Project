using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public class SpendingManagerDBContext : DbContext
    {
        // Your context has been configured to use a 'SpendingManagerDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Models.SpendingManagerDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SpendingManagerDBContext' 
        // connection string in the application configuration file.
        public SpendingManagerDBContext()
            : base("name=SpendingManagerDBContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Ví dụ cấu hình một mối quan hệ
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);

            modelBuilder.Entity<Categories>()
                .HasRequired(c => c.User) // Mối quan hệ bắt buộc với User
                .WithMany(u => u.categories)
                .HasForeignKey(c => c.UserID);

            base.OnModelCreating(modelBuilder);
        }
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