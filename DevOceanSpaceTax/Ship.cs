using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanSpaceTax
{
    public abstract class Ship
    {
        public long baseTax = 0;
        public long taxDiscount = 0;
        public long taxIncrease = 0;

        public int PurchaseYear { get; set; }
        public int TaxYear { get; set; }
        public long Mileage { get; set; }
        


        public Ship()
        {

        }

        public Ship(int purchaseYear, int taxYear, long mileage)
        {
            this.PurchaseYear = purchaseYear;
            this.TaxYear = taxYear;
            this.Mileage = mileage;
            


        }
        

        public int YearsInService()
        {
            return TaxYear - PurchaseYear;
        }
      
        public long MileageMultiplier()
        {
            return Mileage / 1000;
        }

    
        



    }
}
