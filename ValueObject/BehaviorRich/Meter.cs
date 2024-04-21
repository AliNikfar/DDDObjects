using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.BehaviorRich
{
    public class Meter
    {
        private readonly int _value;
        public Meter( int value)
        { 
             _value = value;
        }

        //Using all the class needs in body of the class.  this makes a class being BeaviorRch.
        //{
        public KiloMeter ToKilometer()
        {
            var kilometervValue = _value / 1000;
            return new KiloMeter(kilometervValue);
        }

        public Inch ToInch()
        {
            // it's not right just a implemantation
            var inchValue = _value / 2;
            return new Inch(inchValue);
        }
        //}
    }

}
