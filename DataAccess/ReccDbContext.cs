using Microsoft.EntityFrameworkCore;

namespace ReccAlgWebApi.DataAccess;

public class ReccDbContext : DbContext
{
    private readonly IConfiguration configuration;
    
    public ReccDbContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("Database"));
    }
}