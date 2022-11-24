<<<<<<< HEAD
﻿ using Microsoft.EntityFrameworkCore;
 using net7Api.Entity;

 namespace net7Api.DataAccess.EntityFramework
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=net7db;Trusted_Connection=true");
        }
        public DbSet<Customer> Customers { get; set; }
=======
﻿namespace net7Api.DataAccess.EntityFramework
{
    public class DataContext
    {
>>>>>>> 0ff1a8dda02a0ac6f3a9b5cd035534c8c0ef7f06
    }
}
