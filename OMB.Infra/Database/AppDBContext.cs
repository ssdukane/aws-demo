using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OMB.Infra.Domain.Entities;

namespace OMB.Infra.Database;

public class AppDBContext : DbContext
{
    private IConfiguration _configuration;
    public AppDBContext(IConfiguration configuration) 
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DatabaseConnection"), opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(1).TotalSeconds));
    }

    public DbSet<OMBConfiguration> OMBConfiguration { get; set; } = null;  
}