using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    public class Cargo : Ship
    {
        


        public Cargo(int purchaseYear, int taxYear, long mileage) : base(purchaseYear, taxYear, mileage)
        {
            baseTax = 10000;
            taxDiscount = 736;
            taxIncrease = 1000;

        }


    }
}
