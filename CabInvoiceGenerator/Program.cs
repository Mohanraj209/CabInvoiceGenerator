using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double fare = invoiceGenerator.CalculateFare(5.0, 5);
            Console.WriteLine($"Fare : {fare}");
            Console.ReadLine();
        }
    }
}
