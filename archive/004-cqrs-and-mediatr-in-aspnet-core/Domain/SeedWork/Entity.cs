using MediatR;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SeedWork
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; private set; } = Guid.NewGuid();

        [NotMapped]
        private readonly ConcurrentQueue<IDomainEvent> _domainEvents = new ConcurrentQueue<IDomainEvent>();

        [NotMapped]
        public IProducerConsumerCollection<IDomainEvent> DomainEvents => _domainEvents;

        protected void PublishEvent(IDomainEvent @event)
        {
            _domainEvents.Enqueue(@event);
        }
    }
}
