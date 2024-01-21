using Microsoft.EntityFrameworkCore;
using WebApi.Entities;


namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Admin> Admins => Set<Admin>();
        
    }
}