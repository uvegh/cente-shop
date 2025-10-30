namespace Catalog.Products.Events;

using Catalog.Product.Models;



public record  ProductCreateEvent(Product product):IDomainEvent;