using Fornax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fornax.Infrastructure.Context;

public class DbContextDB : DbContext
{
    private readonly IConfiguration _configuration;

    public DbContextDB(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<User> Users { get; set; }
}

