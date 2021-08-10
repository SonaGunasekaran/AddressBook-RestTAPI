using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using AddressBookRestAPI;

namespace TestAddressBookAPI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRetrieveContact()
        {
            List<Person> actual = new AddressBookJSON().ReadDataFromServer();
            Assert.AreEqual(1, actual.Count);
        }
        [TestMethod]
        public void TestAddContactIntoServer()
        {
            Person person = new Person{ id = 2, FirstName = "Setfan", LastName = "Salvatore", Address = "Disney", City = "NewJersy", State = "Harko", ZipCode = "762346", PhoneNumber = "123455669", EmailId = "setf@gmail.com" } ;
            new AddressBookJSON().AddContactIntoServer(person);
        }
        [TestMethod]
        public void TestAddMultipleData()
        {
            List<Person> person = new List<Person>
            {
                new Person{id=3,FirstName = "Damon", LastName = "Gilbert", Address = "Disney", City = "Madurai", State = "Adol", ZipCode = "65321", PhoneNumber = "987654123", EmailId = "daom@gmail.com" },
                new Person{id=4,FirstName = "Helen", LastName = "Geller", Address = "Disney", City = "Cbe", State = "Gago", ZipCode = "12398", PhoneNumber = "876512300", EmailId = "Helen@gmail.com" }

            };
            new AddressBookJSON().AddMultipleDataIntoServer(person);
            person= new AddressBookJSON().ReadDataFromServer();
            int expected = 5;
            Assert.AreEqual(expected, person.Count);
        }
        [TestMethod]
        public void TestUpdateEmail()
        {
            bool expected = true;
            Person person = new Person { id = 3, FirstName = "Damon", LastName = "Gilbert", Address = "Disney", City = "Madurai", State = "Adol", ZipCode = "65321", PhoneNumber = "987654123", EmailId = "daomgil@gmail.com" };
            bool actual = new AddressBookJSON().UpdateDetailInJsonServer(person);
            Assert.AreEqual(expected, actual);
        }
    }
}
