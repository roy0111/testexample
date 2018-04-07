using NUnit.Framework;
using BloodBankWithUnitTesting.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace testingBloodBank
{   [TestFixture]
    class SearchBloodUnitTest
    {
        searchBlood obj = new searchBlood();


        [Test()]//test case 1 
        public void CheckNullTestCase()
        {
            string dropDownFieldText = "123456789";

            bool result = obj.CheckFieldValidity(dropDownFieldText);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]//test case 2
        public void SearchDonorByBlood()
        {
            string requiredBloodGroup = "k+";
            string requiredArea = "Badda";

            bool result = obj.CheckBloodAvaiability(requiredBloodGroup, requiredArea);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }


    }
}
