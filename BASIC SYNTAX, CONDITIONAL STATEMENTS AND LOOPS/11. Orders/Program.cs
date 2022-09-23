using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int days = 0;
            int capsCount = 0;
            double totalSum = 0;

            for (int i = 1; i <= orders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsCount = int.Parse(Console.ReadLine());
                Console.WriteLine($"The price for the coffee is: ${days*capsCount*pricePerCapsule:f2}");
                totalSum += days * capsCount * pricePerCapsule;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");

            
        }
    }
}
