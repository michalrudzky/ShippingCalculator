namespace ShippingCalculator
{
    class Zone2 : DestinationZone
    {
        public Zone2()
        {
            requiresAdditionalFee = true;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.12m;
        }
    }
}
