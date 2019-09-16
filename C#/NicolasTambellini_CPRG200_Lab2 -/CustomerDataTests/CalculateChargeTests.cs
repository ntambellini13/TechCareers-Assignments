using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateChargeTest_NegativekWhResidential_Throws()
        {
            // Arrange
            Customer residentialCustomer = new Customer(1, "Carol", "R");
            int kwhUsed = -100;

            // Act
            decimal CustomerCharge =  residentialCustomer.CalculateCharge(kwhUsed);

            // Assert
            Assert.Fail(); 
        }

        [TestMethod()]
        public void CalculateChargeTest_ValidKwhResidential_ReturnsCorrectChargeAmount()
        {
            // Arrange
            int AccountNo = 1;
            string CustomerName = "Carol";
            string CustomerType = "R";
            int kwhUsed = 100;

            Customer residentialCustomer = new Customer(AccountNo, CustomerName, CustomerType);

            // Act
            double test = (double)residentialCustomer.CalculateCharge(kwhUsed);

            // Assert
            Assert.AreEqual(11.20, test, 0.0001);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateChargeTest_NegativekWhCommercial_Throws()
        {
            // Arrange
            Customer commercialCustomer = new Customer(3, "Frank", "C");
            int kwhUsed = -10;

            // Act
            decimal ChargeAmount =  commercialCustomer.CalculateCharge(kwhUsed);

            // Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateChargeTest_ValidKwhCommercial_ReturnsCorrectChargeAmount()
        {
            // Arrange
            Customer commercialCustomer = new Customer(4, "Gertrude", "C");
            int kwhUsed = 2000;

            // Act
            double test = (double)commercialCustomer.CalculateCharge(kwhUsed);

            // Assert
            Assert.AreEqual(105.00, test, 0.0001);
        }

        [TestMethod()]
        public void CalculateChargeTest_NegativePeak_And_NegativeOffPeakkWhIndustrial_Throws()
        {
            // Arrange
            Customer industrialCustomer = new Customer(5, "Anthony", "I");
            int peakKwhUsed = -1000;
            int offPeakKwhUsed = -1000;

            // Act
            Action actual = () => industrialCustomer.CalculateCharge(peakKwhUsed, offPeakKwhUsed);

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
        }

        [TestMethod()]
        public void CalculateChargeTest_ValidPeaKwh_And_ValidOffPeakKwh_ReturnsCorrectIndustrialChargeAmount()
        {
            // Arrange
            Customer industrialCustomer = new Customer(6, "Vincent", "I");
            int peakKwhUsed = 2000;
            int offPeakKwhUsed = 2000;

            // Act
            double test = (double)industrialCustomer.CalculateCharge(peakKwhUsed, offPeakKwhUsed);

            // Assert
            Assert.AreEqual(209.00, test, 0.0001);
        }
    }
}