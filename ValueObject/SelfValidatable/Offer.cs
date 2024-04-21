namespace ValueObject
{
    public class Offer 
    {
        public OfferPrice Price { get; private set; }
        public void Raise()
        {
            Price = Price.Raise();
        }
        public void suggest(int additionvalue)
        {
            Price = Price.suggest(additionvalue);
        }

    }
}