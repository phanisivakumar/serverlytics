using Microsoft.EntityFrameworkCore;

namespace Serverlytics.Context;

public class ServerlyticsContext : DbContext
{
    public ServerlyticsContext(DbContextOptions<ServerlyticsContext> options) : base(options)
    {
    }

    public DbSet<ServerHealth> ServerHealth { get; set; }
}