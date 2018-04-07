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
            string dropDownFieldText = null;

            bool result = obj.CheckFieldValidity(dropDownFieldText);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }



        [Test()]//test case 3
        public void SearchAvailableDonorByBlood()
        {
            string requiredBloodGroup = "ab+";

            bool result = obj.CheckBloodGroupDonorAvailableOrNot(requiredBloodGroup);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]//test case 4
        public void CheckAreaAvailableOrNot()
        {
            string areaName = "Badda";

            bool result = obj.CheckAreaAvailableOrNot(areaName);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]//test case 2
        public void SearchDonorByBloodInArea()
        {
            string requiredBloodGroup = "b+";
            string requiredArea = "Badda";

            bool result = obj.CheckBloodAvailableInParticulerAreaOrNot(requiredBloodGroup, requiredArea);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
