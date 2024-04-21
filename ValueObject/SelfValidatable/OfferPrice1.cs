namespace ValueObject
{
    // in OfferPrice1 removed Repetitious works by implementing a BaseValueObject.
    public class OfferPrice1 : BaseValueObject<OfferPrice1>
    {
        public int Price
        {
            get
            { return _price; }
        }
        private readonly int _price;
        public OfferPrice1(int value)
        {
            if (_price < 100000)
            {
                throw new Exception();
            }
            _price = value;
        }
        public OfferPrice Raise()
        {
            int additionalValue = 0;

            if (Price >= 100 && Price < 2000000)
            {
                additionalValue = 100;
            }
            else if (Price >= 2000000 && Price < 10000000)
            {
                additionalValue = 500;
            }
            else
            {
                additionalValue = 1000000;
            }
            return new OfferPrice(Price + additionalValue);
        }
        public OfferPrice suggest(int additionvalue)
        {
            if (((Price >= 100 && Price < 2000000) && (additionvalue >= 100))
                || ((Price >= 2000000 && Price < 10000000) && (additionvalue <= 500))
                || (Price >= 10000000 && additionvalue >= 10000000))
            {
                return new OfferPrice(Price + additionvalue);
            }
            else
                throw new Exception();
        }

        protected override bool EqualsCore(OfferPrice1 other)
        {
            return Price == other.Price;
        }

        protected override int GetHashCodeCore()
        {
            //it's just returns a int , look at dotnet texts for right implementation.
           return 100 * Price;
        }
    }
}