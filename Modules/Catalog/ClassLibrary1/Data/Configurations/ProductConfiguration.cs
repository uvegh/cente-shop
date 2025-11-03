



namespace Catalog.Data.Configurations;

public  class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Price).IsRequired();
        builder.Property(e => e.ImageUrl).HasMaxLength(100);
        builder.Property(e => e.Price).IsRequired();



    }
}
