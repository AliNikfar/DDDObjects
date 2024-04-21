namespace ValueObject
{

    public class OfferPrice
    {
        public int Price 
        {
            get
            { return _price; }
        }
        private readonly int _price;
        public OfferPrice( int value)
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
                additionalValue  = 500;
            }
            else
            {
                additionalValue  = 1000000;
            }
            return new OfferPrice( Price + additionalValue);
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
        public override bool Equals(object obj)
        {
            //we haveto ovverride all the operate to make sure operate will work right.
            //or instead of this way we can create a ValueObject class you can see implementation on the top of this page
            //== 
            //!=
            //GetHashCode
            return base.Equals(obj);
        }

    }
}