namespace ShippingCalculator
{
    class Zone2 : DestinationZone
    {
        public Zone2()
        {
            requiresAdditionalFee = true;
        }

        public override void CalculateFee(double price, ref double fee)
        {
            fee = price * 0.12;
        }
    }
}
