﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOceanSpaceTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax.Tests
{
    [TestClass()]
    public class TaxServicesTests
    {
        [TestMethod()]
        public void TaxCalculatorTestCargo()
        {
            var cargo = new Cargo(2332, 2369, 344789);
            var taxServices = new TaxServices(cargo);
            long actualResult = taxServices.TaxCalculator();
            long expectedResult = 326768;

            Assert.AreEqual(expectedResult, actualResult);
        }
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