using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressbookTests.Tests;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Sergey");
            newData.LastName = "Gucci";
            newData.MiddleName = "Kelvin";

            app.Contacts.Modify(1, newData);
        }        
    }
}
