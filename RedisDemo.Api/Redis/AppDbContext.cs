using Microsoft.EntityFrameworkCore;
using RedisDemo.Api.Models;
using System.Reflection;

namespace RedisDemo.Api.Redis
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
                        
            base.OnModelCreating(modelBuilder);
        }
    }
}
