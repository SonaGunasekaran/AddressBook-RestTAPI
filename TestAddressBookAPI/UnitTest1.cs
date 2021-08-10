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
    }
}
