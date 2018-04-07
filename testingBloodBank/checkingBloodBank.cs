using NUnit.Framework;
using BloodBankWithUnitTesting.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloodbankTestingNamespace.Tests
{
    [TestFixture()]
    public class CheckingBloodBank
    {
        passwordChange obj = new passwordChange();
      
        [Test()]//test case 1 
        public void CheckEmptyTestCase()
        {
            string password="123456789";

            bool result = obj.CheckEmpty(password);
            bool expectedResult = false; 
            Assert.AreEqual(expectedResult,result);
        }

        [Test()]//test case 2

        public void PasswordCheckTestCase()
        {
            string newPassword = "123456789";
            string confirmedPassword = "123456789";
            bool result = obj.NewPasswordConfirmPasswordMatchingCheck(newPassword, confirmedPassword);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }


        [Test()]//test case 3
        public void CheckoldPasswordTestCase()
        {
            string usermail = "birat0111@gmail.com";
            string userOldPassWord = "12365456789";
            bool result = obj.CheckOldPassowordExistance(usermail, userOldPassWord);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }


        [Test()]//test case 4
        public void UpdatePassordTestCase()
        {
            string usermail = "birat0111@gmail.com";
            string user_NewPassword = "123456789";
            bool result = obj.UpdatePasswordFunction(usermail, user_NewPassword);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }
    }
}