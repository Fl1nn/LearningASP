using Domain.SeedWork;

namespace Domain.AggregatesModel.OrderAggregate
{
    public class Order: Entity, IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }
        private readonly List<OrderItem> _items = new();
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();
    }
}
