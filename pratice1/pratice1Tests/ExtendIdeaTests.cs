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
    public class ExtendIdeaTests
    {
        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            // arrange
            string _fixPassword = "yhn";
            HashMaker hash = new HashMaker();
            string input = hash.GetHash(_fixPassword);
            ExtendIdea target = new ExtendIdea(_fixPassword);
            bool expect = true;
            bool actual;
            // act
            actual = target.CheckAuthentication(input);
            // assert
            Assert.AreEqual(expect,actual);
        }
    }
}