namespace WebApi.Data;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Admin;



    public class AppDbContext : DbContext
    {
         protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }
    
        

        public DbSet<AdminModel> Admins => Set<AdminModel>();
        
    }
   