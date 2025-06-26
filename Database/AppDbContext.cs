using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    /// <summary>
    /// Database field
    /// </summary>
    public DbSet<StoreModels> StoreItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}