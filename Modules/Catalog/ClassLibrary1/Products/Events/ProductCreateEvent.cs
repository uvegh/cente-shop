namespace Catalog.Products.Events;

public record  ProductCreateEvent(Product  Product):IDomainEvent;