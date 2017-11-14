using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenZone = "";

            do
            {
                Console.WriteLine("What is the destination zone?");
                chosenZone = Console.ReadLine();
            } while (!chosenZone.Equals("exit"));
        }
    }
}
