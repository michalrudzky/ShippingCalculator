namespace ShippingCalculator
{
    public class Zone3 : DestinationZone
    {
        public Zone3()
        {
            requiresAdditionalFee = false;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.08m;
        }
    }
}
