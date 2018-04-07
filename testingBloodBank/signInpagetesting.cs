using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BloodBankWithUnitTesting;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingBloodBank
{
    [TestFixture]
    public class signInpagetesting
    {
        SignIn obj = new SignIn();

        [Test]
        public void SignInPageFeildValidityTest()
        {
            string password = "123456789";
            bool result = obj.LengthCheckOfField(password);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void UserPasswordValidity()
        {
            string password = "123456789";
            string mail = "birat@gmail.com";
            bool result = obj.ValidateUserMailPasswordExistance(mail,password);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
