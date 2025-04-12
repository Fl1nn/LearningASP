using Domain.SeedWork;

namespace Domain.AggregatesModel.OrderAggregate
{
    public class OrderItem : Entity
    {
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Total => Quantity * UnitPrice;

        public OrderItem(Guid id, string productName, int quantity, decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
