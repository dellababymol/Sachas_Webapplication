using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO;

namespace Sachas_website.Tests
{
    [TestClass]
    public class UnitTestRegister
    {
        private RegisterBO objRegisterBOTest = new RegisterBO();

        [TestMethod]
        public void ExistingUserName()
        {
            bool result = objRegisterBOTest.validateBOUserName("first", "last", "username123", "password123", "abc@b.cjm");
            Assert.AreEqual(result, false);
        }
    }
}
