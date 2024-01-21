using Microsoft.EntityFrameworkCore;
using WebApi.Models.Admin;


namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<AdminModel> Admins => Set<AdminModel>();
        
    }
}