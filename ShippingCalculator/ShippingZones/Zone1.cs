namespace ShippingCalculator
{
    public class Zone1 : DestinationZone
    {
        public Zone1()
        {
            requiresAdditionalFee = false;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.25m;
        }
    }
}
