using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.Immutable
{
    public class DateTimeCheck
    {
        public void test()
        {
            DateTime dt01 = new DateTime(2014, 01, 20);
            //changing  the values of a value object will not change  valu of the valueObject ,
            //it will create a new instance of the value object (ofcourse a DateTime type is a Immutable valuObject)
            DateTime dt02 = dt01.AddDays(360);
            DateTime dt03 = dt01.AddDays(-3);
            if (dt01 == new DateTime(2014, 01, 20))
            {
                Console.WriteLine("the value Object Is Immutable");
            }
        }
    }
}
