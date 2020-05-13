using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaraMcDonagh_S00185883;
namespace IncreasedTest
{
    [TestClass]
    public class UnitTest1
    {
        //Write a unit test to check that IncreasePrice works. (10 marks) 
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            Phone p1 = new Phone();
            decimal price = 550;

            //Act
            p1.IncreasePrice(500,0.10);

            //Asssert
            Assert.AreEqual(p1.Price, price);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            Phone p1 = new Phone();
            decimal price = 440;

            //Act
            p1.IncreasePrice(400, 0.10);

            //Asssert
            Assert.AreEqual(p1.Price, price);
        }
    }
}
