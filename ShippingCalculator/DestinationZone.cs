using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator
{
    public abstract class DestinationZone
    {
        protected bool requiresAdditionalFee;

        public virtual void CalculateFee(double price, ref double fee) { }

        public static DestinationZone GetZone(string zone)
        {
            switch(zone)
            {
                case "zone1":
                    return new Zone1();
                case "zone2":
                    return new Zone2();
                case "zone3":
                    return new Zone3();
                case "zone4":
                    return new Zone4();
                default:
                    return null;
            }
        }
    }
}
