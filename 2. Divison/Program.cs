using System;

namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            if (i%10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (i % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (i % 6 == 0 )
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (i % 3 == 0 )
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (i % 2 ==0 )
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
  
        }
    }
}
