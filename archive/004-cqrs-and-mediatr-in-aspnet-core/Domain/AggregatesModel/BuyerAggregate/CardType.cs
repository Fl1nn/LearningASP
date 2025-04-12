namespace Domain.AggregatesModel.BuyerAggregate
{
    public class CardType
    {
        public CardTypeEnum Type { get; private set; }
        public string LastFourDigits { get; private set; }

        public CardType(CardTypeEnum type, string lastFourDigits)
        {
            Type = type;
            LastFourDigits = lastFourDigits;
        }
    }
}
