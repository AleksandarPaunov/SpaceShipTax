using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    public class Family:Ship
    {

 
        public Family(int purchaseYear, int taxYear, long mileage) : base(purchaseYear, taxYear, mileage)
        {

            baseTax = 5000;
            taxDiscount = 355;
            taxIncrease = 100;
        }


    }
}
