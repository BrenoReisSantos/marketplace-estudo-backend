using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Models.Context;

public class MarketplaceContext : DbContext
{
    public DbSet<Store> Stores => Set<Store>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Category> Categories => Set<Category>();

    public MarketplaceContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketplaceContext).Assembly);
}
