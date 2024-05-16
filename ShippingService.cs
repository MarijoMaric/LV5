using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public class ShippingService
    {
        private double pricePerUnit;

        public ShippingService(double pricePerUnit) {
        
            this.pricePerUnit = pricePerUnit;
        }

        public double CalculateShippingPrice(IShipable item)
        {
            return item.Weight * pricePerUnit;
        }


    }
}
