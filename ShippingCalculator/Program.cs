using System;

namespace ShippingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenZone = "";

            do
            {
                if (!chosenZone.Equals("exit"))
                {
                    Console.WriteLine("What is the destination zone?");
                    chosenZone = Console.ReadLine();

                    if (chosenZone != null)
                    {
                        DestinationZone destinationZone = DestinationZone.GetZone(chosenZone);

                        string priceStr;
                        Console.WriteLine("What is the item price?");
                        priceStr = Console.ReadLine();
                        decimal itemPrice = decimal.Parse(priceStr);

                        ShippingFeeDelegate del = destinationZone.CalculateFee;

                        if (destinationZone.AdditionalFeeNeeded())
                        {
                            del += delegate (decimal price, ref decimal fee)
                            {
                                fee += 25.0m;
                            };
                        }

                        decimal shippingFee = 0.0m;
                        del(itemPrice, ref shippingFee);

                        Console.WriteLine("Shipping fee: {0}", shippingFee);
                    }
                    else
                        Console.WriteLine("");
                }
            } while (!chosenZone.Equals("exit"));
        }
    }
}
