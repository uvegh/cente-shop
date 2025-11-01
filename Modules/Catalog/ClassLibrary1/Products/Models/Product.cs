using Catalog.Products.Events;

namespace Catalog.Products.Models;

public class Product : Aggregate<Guid>
{
    public string Name { get; private  set; } = default!;
    public List<string> Category { get; private set; } = new();
    public string Description { get; private set; } = default!;
    public string ImageUrl { get; private set; } = default!;
    public decimal Price { get; private set; }

    public static Product Create(Guid id, string name, List<string> category, string description, string imageUrl, decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        var product = new Product
        {
            Id = id,
            Name = name,
            Category = category,
            Description = description,
            ImageUrl = imageUrl,
            Price = price
        };
        //create new domain event productCreateEvent
       product.AddDomainEvent(new ProductCreateEvent(product));


    return product;
       
    }

    public   void Update (string name, List<string> category, string description, string imageUrl, decimal price)
    {


        Name = name;
        Category = category;
        Description = description;
        ImageUrl = imageUrl;
        Price = price;

        if (price != Price)
        {
            AddDomainEvent(new ProductUpdatePriceEvent(this));
        }

        
    }

};

