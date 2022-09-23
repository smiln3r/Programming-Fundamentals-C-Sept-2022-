using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceOfLight = double.Parse(Console.ReadLine());
            double priceOfrobes = double.Parse(Console.ReadLine());
            double priceOfbelts = double.Parse(Console.ReadLine());

            double allSum = 0;
            //allSum = priceOfLight * numOfStudents+(numOfStudents * 0.1) + priceOfrobes * numOfStudents + priceOfbelts * numOfStudents;
            double sumForLight = priceOfLight * numOfStudents + (numOfStudents * 0.1);
            sumForLight=Math.Ceiling(sumForLight);
            double sumForRobes = priceOfrobes * numOfStudents;
            sumForRobes=Math.Ceiling(sumForRobes);
            //double priceOfBelts = priceOfbelts * numOfStudents;
            double sumForBelts = 0;
            if (numOfStudents>=6)
            {
                int numOfFree = numOfStudents % 6;
                sumForBelts = priceOfbelts * (numOfStudents - numOfFree);
            }
            else
            {
                sumForBelts = priceOfbelts * numOfStudents;
            }
            sumForBelts= Math.Ceiling(sumForBelts);
            allSum = sumForLight + sumForRobes + sumForBelts;

            // Console.WriteLine($"{Math.Ceiling(allSum):f2}");
            allSum = Math.Ceiling(allSum);



            if (money>=allSum)
            {
                Console.WriteLine($"The money is enough - it would cost {allSum:f2}lv.");

            }
            else
            {
                Console.WriteLine($"John will need {allSum-money:f2}lv more.");
            }

        }
    }
}
