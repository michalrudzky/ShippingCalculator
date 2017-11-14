namespace ShippingCalculator
{
    public class Zone4 : DestinationZone
    {
        public Zone4()
        {
            requiresAdditionalFee = true;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.04m;
        }
    }
}
