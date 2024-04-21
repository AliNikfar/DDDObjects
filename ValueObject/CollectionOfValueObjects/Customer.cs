using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDObjects.ValueObject.CollectionOfValueObjects
{

    // defenition List of a ValuObject is  wrong from the Base because of the folloing things
    // 1- push you to add id over time
    // 2- the value object define by its value and when we have a list over time we need selection using Id
    // 3- type of phone numbers is not clear

    public class Customer
    {
        //public List<PhoneNumber> PhoneNumbers { get; set; }
        //instead of this using following way
        public Phonebook Phonebook { get; set; }
    }

    public class PhoneNumber
    {
        private readonly string phoneNumber;
        public PhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }



    // when we need more than 1 value Object we can use the following way

    public class Phonebook
    {
        private readonly PhoneNumber homeNumber;
        private readonly PhoneNumber workNumber;
        private readonly PhoneNumber fax;

        public Phonebook(PhoneNumber homeNumber,PhoneNumber workNumber , PhoneNumber fax)
        {
            this.homeNumber = homeNumber;
            this.workNumber = workNumber;
            this.fax = fax;
        }
    }

}
