using Microsoft.VisualStudio.TestTools.UnitTesting;
using pratice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice1.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            // arrange
            IAccountDao dao = new StubAccountDao();
            IHash hash = new StubHash();
            Validation target = new Validation(dao, hash);
            string id = "1234";
            string password = "erferfe";
            bool expect = true;
            bool actual;
            // act
            actual = target.CheckAuthentication(id, password);
            // assert
            Assert.AreEqual(expect, actual);
        }
    }
}