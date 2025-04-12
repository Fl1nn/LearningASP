using Domain.SeedWork;

namespace Domain.AggregatesModel.BuyerAggregate
{
    public class Buyer : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<CardType> Cards { get; private set; } = new();

        public Buyer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        public void AddCard(CardType card)
        {
            if (!Cards.Any(c => c.Type == card.Type && c.LastFourDigits == card.LastFourDigits))
                Cards.Add(card);
        }
    }
}
}
