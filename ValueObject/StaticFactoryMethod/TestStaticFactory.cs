using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.StaticFactoryMethod
{
    public class TestStaticFactory
    {
        public TestStaticFactory()
        {
            //Timespan timespan = new TimeSpan();
            //instead of top instansiate ,  FromDays method presents a easy way to create an instance ;
            TimeSpan timespan01 = TimeSpan.FromDays(2);
            TimeSpan timespan02 = TimeSpan.FromDays(2);
        }
    }
}
