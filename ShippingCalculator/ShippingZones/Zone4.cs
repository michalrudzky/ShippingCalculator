namespace ShippingCalculator
{
    public class Zone4 : DestinationZone
    {
        public Zone4()
        {
            requiresAdditionalFee = true;
        }

        public override void CalculateFee(double price, ref double fee)
        {
            fee = price * 0.04;
        }
    }
}
