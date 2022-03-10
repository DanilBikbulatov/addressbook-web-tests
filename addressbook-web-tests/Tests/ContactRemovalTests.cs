using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : ContactsTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToHomePage();
            SelectContact(1);
            RemoveContact();           
        }


        

       

      





    }
}


