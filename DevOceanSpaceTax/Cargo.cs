using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    public class Cargo : Ship
    {
        static readonly long baseTax=10000;
        static readonly long taxDiscount= 736;
        static readonly long taxIncrease = 1000;


        public Cargo(int purchaseYear, int taxYear, long mileage) : base(purchaseYear, taxYear, mileage)
        {


        }


        public long DueTax()
        {
            return baseTax + MileageMultiplier() * taxIncrease - YearsInService() * taxDiscount;
        }
    }
}
