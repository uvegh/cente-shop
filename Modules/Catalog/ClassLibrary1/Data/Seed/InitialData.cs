

namespace Catalog.Data.Seed;

public class InitialData
{
    public static IEnumerable<Product> Products => new List<Product>
{
    Product.Create(new Guid("a623e3a5-9db6-4178-b556-13995f442291"), "Acura Shampoo", ["cat1"], "Nice shampoo", "http:placeholder", 3),

    Product.Create(new Guid("2a3ff3a2-f73f-4a51-a774-e85ac10d3023"), "Dove Soap", ["cat1"], "Nice Soap", "http:placeholder", 1),

    Product.Create(new Guid("92435543-5351-49fd-8464-49e5ee15d11d"), "Meat Pie", ["cat2"], "nice Meat Pie", "http:placeholder", 3)
};
}
