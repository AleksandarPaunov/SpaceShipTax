using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    class Family:Ship
    {

        static readonly long baseTax = 5000;
        static readonly long taxDiscount = 355;
        static readonly long taxIncrease = 100;


        public Family(int purchaseYear, int taxYear, long mileage) : base(purchaseYear, taxYear, mileage)
        {


        }


        public long DueTax()
        {
            return baseTax + MileageMultiplier() * taxIncrease - YearsInService() * taxDiscount;
        }
    }
}
