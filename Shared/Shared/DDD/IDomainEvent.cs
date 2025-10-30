
//interface for domain event in DDD pattern
using MediatR;
namespace Shared.DDD
{
    public  interface IDomainEvent: INotification
    {
        Guid EventId => Guid.NewGuid();
        public DateTime OccuredOn => DateTime.UtcNow;
        public string EventType => GetType().Name;
    }
}
