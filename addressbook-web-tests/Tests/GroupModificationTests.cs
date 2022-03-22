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
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "yyy";
            newData.Footer = "qqq";

            app.Groups.Modify(0, newData);
        }
    }
}
