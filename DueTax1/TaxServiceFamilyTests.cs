using DevOceanSpaceTax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DueTax1
{
    [TestClass]
    public class TaxServiceFamilyTests
    {
        [TestMethod]
        public void TaxCalculatorTestFamily()
        {
            var family = new Family(2300, 2307, 2344);
            var taxServices = new TaxServices(family);
            long actualResult = taxServices.TaxCalculator();
            long expectedResult = 2715;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
