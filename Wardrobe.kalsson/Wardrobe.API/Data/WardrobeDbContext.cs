using Microsoft.EntityFrameworkCore;
using Wardrobe.API.Models;

namespace Wardrobe.API.Data;

public class WardrobeDbContext : DbContext
{
    public WardrobeDbContext(DbContextOptions<WardrobeDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<WardrobeItem> WardrobeItems { get; set; }
}