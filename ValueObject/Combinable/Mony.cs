using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.Combinable
{
    public  class Mony : BaseValueObject<Mony>
    {
        public int Value
        {
            get
            {
                return _value;
            }
        }
        private readonly int _value;
        public Mony(int value)
        {
            _value = value;
        }
        public Mony Add(Mony input)
        {
            return new Mony(_value+input.Value);
        }
        public Mony Subtract(Mony input)
        {
            return new Mony(_value - input.Value);
        }

        // we haveto create posibilities to make valueObjects Combine together
        //{
        public static Mony operator  + (Mony left , Mony right)
        {
            return left.Add(right);
        }
        public static Mony operator -(Mony left, Mony right)
        {
            return left.Subtract(right);
        }
        //}
        protected override bool EqualsCore(Mony other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
