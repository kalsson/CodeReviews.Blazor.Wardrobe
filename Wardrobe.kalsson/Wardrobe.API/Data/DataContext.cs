using Microsoft.EntityFrameworkCore;
using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<WardrobeItem> WardrobeItems { get; set; }
}