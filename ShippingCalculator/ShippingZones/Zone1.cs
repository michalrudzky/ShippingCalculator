namespace ShippingCalculator
{
    public class Zone1 : DestinationZone
    {
        public Zone1()
        {
            requiresAdditionalFee = false;
        }

        public override void CalculateFee(double price, ref double fee)
        {
            fee = price * 0.25;
        }
    }
}
