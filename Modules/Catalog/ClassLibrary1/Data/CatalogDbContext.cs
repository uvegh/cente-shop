

namespace Catalog.Data;

public class CatalogDBContext : DbContext
{

    public CatalogDBContext(DbContextOptions<CatalogDBContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("catalog");
        //use builder.apply configuration instead
        //builder.Entity<Product>(entity =>
        //{
        //    entity.HasKey(e => e.Id);
        //    entity.Property(e => e.Name).IsRequired();
        //    entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");


        //});
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }

}