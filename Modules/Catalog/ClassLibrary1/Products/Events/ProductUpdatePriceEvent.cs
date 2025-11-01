namespace Catalog.Products.Events;

public  record ProductUpdatePriceEvent(Product Product):IDomainEvent;

