using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator
{
    public delegate void ShippingFeeDelegate(decimal price, ref decimal fee);

    public abstract class DestinationZone
    {
        protected bool requiresAdditionalFee;

        public virtual void CalculateFee(decimal price, ref decimal fee) { }

        public bool AdditionalFeeNeeded()
        {
            return requiresAdditionalFee;
        }

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
