using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptestTriangle_Type
{
    internal class Program
    {

         
          

             
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first side:(or press 'e' to exit): ");
                string input = Console.ReadLine();
                if (input?.Trim().ToLower() == "e")
                {
                    Environment.Exit(0);
                }
                if (!double.TryParse(input, out double side1) || side1 <= 0)
                {
                    Console.WriteLine("invalid side length");
                    continue;
                }

                Console.WriteLine("Enter the second side:");
                if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
                {
                    Console.WriteLine("invalid side length");
                    continue;
                }

                Console.WriteLine("Enter the third side:");
                if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
                {
                    Console.WriteLine("invalid side length");
                    continue;
                }

                if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    Console.WriteLine("invalid side length");
                    continue;
                }

                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
        }
    }
}
