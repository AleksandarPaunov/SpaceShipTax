using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    public static class Messages
    {
        public static void YearMade()
        {
            Console.WriteLine("Please enter the year your ship was manufactured");
        }

        public static void TaxYear()
        {
            Console.WriteLine("Please enter the tax year");
        }

        public static void ShipType()
        {
            Console.WriteLine("Please select your ship type:");
            Console.WriteLine("Press 1 for Cargo");
            Console.WriteLine("Press 2 for Family");

        }
        public static void MileageInMiles()
        {
            Console.WriteLine("Please enter your ship's mileage:");
        }
    }
}
