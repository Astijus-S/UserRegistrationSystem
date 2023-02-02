using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserRegistrationSystem.Entities;

namespace UserRegistrationSystem.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
