using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookRestAPI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Addresses { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailId { get; set; }
    }
}
