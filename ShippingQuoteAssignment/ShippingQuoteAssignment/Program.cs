using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package width:");
            double packageWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double packageHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double packageLength = Convert.ToDouble(Console.ReadLine());
            
             double packageDimensions = (packageWidth + packageHeight + packageLength);

            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Your package is too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            double totalQuote = packageDimensions * packageWeight / 100;
                
            
            Console.WriteLine("Your estimated total for shipping this package is: $"+totalQuote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }            
    }
}
