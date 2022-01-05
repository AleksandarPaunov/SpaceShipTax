using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    class Program
    {
        public static int ShipChoice()
        {

            Messages.ShipType();
            bool IsValidInput = int.TryParse(Console.ReadLine(), out int choice);


            while (choice != 1 & choice != 2)
            {
                    
              Console.Clear();
              Console.WriteLine("Invalid selection, please select 1 for Cargo Ship or 2 for Familly Ship");
                IsValidInput = int.TryParse(Console.ReadLine(), out choice);

            }

            

            return choice;
        }
        public static int TaxYearChoice()
        {
            Console.Clear();
            Messages.TaxYear();
            bool IsValid = int.TryParse(Console.ReadLine(), out int taxYear);

            while(taxYear<2300 || taxYear>2500)
            {
                Console.Clear();
                Console.WriteLine("Invalid selection, please select year between 2300-2500");
                IsValid= int.TryParse(Console.ReadLine(), out taxYear);
            }

            return taxYear;

        }

        public static int YearMade()
        {

            
            bool IsValid = int.TryParse(Console.ReadLine(), out int yearMade);

            while (yearMade < 2200 || yearMade > 2500)
            {
                Console.Clear();
                Console.WriteLine("Please select year in the range between 2200-2500");
                IsValid = int.TryParse(Console.ReadLine(), out yearMade);
            }

            return yearMade;

        }


        public static long MileageValidation()
        {
            Console.Clear();
            Messages.MileageInMiles();
            bool IsValid = int.TryParse(Console.ReadLine(), out int mileage);

            while (mileage < 0 || mileage > 9999999)
            {
                Console.Clear();
                Console.WriteLine("Please select your ship's mileage, acceptable values 0- 9999999");
                IsValid = int.TryParse(Console.ReadLine(), out mileage);
            }

            return mileage;

        }

        

        static void Main(string[] args)
        {
            
            int shipChoice = ShipChoice();
            
            
            int taxYear = TaxYearChoice();
            Messages.YearMade();
            
            int yearMade = YearMade();

            if (taxYear < yearMade)
            {
                Console.WriteLine("Your ship cannot be taxed before being manufactured :) ");

            }



            else
            {


                long mileage = MileageValidation();


                if (shipChoice == 1)
                {

                    var cargo = new Cargo(yearMade, taxYear, mileage);

                    Console.WriteLine("For your cargo vessel the due tax is: " + cargo.DueTax() + " DVS");
                    //326768
                }

                else
                {


                    var family = new Family(yearMade, taxYear, mileage);
                    Console.WriteLine("For your family vessel the due tax amount is: " + family.DueTax() + " DVS");

                    //2715


                }






            }

            




        }
    }
}
