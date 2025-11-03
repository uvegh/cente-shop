



namespace Catalog.Data.Seed;

public class CatalogDataSeeder(CatalogDBContext dbContext):IDataSeeder
{
    
    public async Task SeedAllAsync()
    {
        //check is thers no record on table,always check if theres nno record before adding seed data
        if (!await dbContext.Products.AnyAsync()){
            //add range from initialData
            await dbContext.Products.AddRangeAsync(InitialData.Products);
            await dbContext.SaveChangesAsync();
        }

    }
}
