using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
   public class TaxServices
    {

        public Ship Ship { get; set; }

        public TaxServices(Ship ship)
        {
            this.Ship = ship;
        }


        public long TaxCalculator()
        {
            
            return Ship.baseTax + Ship.MileageMultiplier() * Ship.taxIncrease - Ship.YearsInService() * Ship.taxDiscount;
            
        }
    }




}
