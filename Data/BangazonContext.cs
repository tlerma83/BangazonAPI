using Microsoft.EntityFrameworkCore;
using BangazonAPI.Models;


namespace BangazonAPI.Data
{
    public class BangazonContext : DbContext
    {
        public BangazonContext(DbContextOptions<BangazonContext> options)
            : base(options)
        { }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Computer> Computer { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<EmployeeComputer> EmployeeComputer { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<TrainingProgram> TrainingProgram { get; set; }
        public DbSet<EmployeeTraining> EmployeeTraining { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

            modelBuilder.Entity<Customer>()
                .Property(c => c.AcctCreatedOn)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
                

        }
    }
}
