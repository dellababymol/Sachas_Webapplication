using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO;

namespace Sachas_website.Tests
{
    [TestClass]
    public class UnitTestLogin
    {
        private LoginBO objLoginTest = new LoginBO();

        [TestMethod]
        public void CorrectCredentials()
        {
            bool result = objLoginTest.AuthenticateExitingUser("username123", "password123");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IncorrectCredentials()
        {
            bool result = objLoginTest.AuthenticateExitingUser("username123", "password1234");
            Assert.AreEqual(result, false);
        }
    }
}
