using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
    }
}
