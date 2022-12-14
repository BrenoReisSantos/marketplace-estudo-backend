using Microsoft.EntityFrameworkCore;

namespace Marketplace.Models.Context;

public class MarketplaceContext : DbContext
{
    public MarketplaceContext(DbContextOptions options) : base(options)
    {
    }
}
