namespace ShippingCalculator
{
    public class Zone3 : DestinationZone
    {
        public Zone3()
        {
            requiresAdditionalFee = false;
        }

        public override void CalculateFee(double price, ref double fee)
        {
            fee = price * 0.08;
        }
    }
}
