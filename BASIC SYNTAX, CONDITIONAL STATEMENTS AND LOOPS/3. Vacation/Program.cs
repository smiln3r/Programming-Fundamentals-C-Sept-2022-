using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();   
            string day = Console.ReadLine();
            double price = 0;

            if (typeGroup=="Students")
            {
                if (day=="Friday")
                {
                    price = numOfPeople * 8.45;
                }
                else if (day=="Saturday")
                {
                    price = numOfPeople * 9.80;
                }
                else//Sunday
                {
                    price = numOfPeople * 10.46;
                }
                if (numOfPeople>=30)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    if (numOfPeople>=100)
                    {
                        numOfPeople -= 10;
                    }
                    price = numOfPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    if (numOfPeople>=100)
                    {
                        numOfPeople -= 10;
                    }
                    price = numOfPeople * 15.60;
                }
                else//Sunday
                {
                    if (numOfPeople>=100)
                    {
                        numOfPeople -= 10;
                    }
                    price = numOfPeople * 16;
                }
                if (numOfPeople>=100)
                {
                    price = numOfPeople - 10;
                }
            }
            else//Regular
            {
                if (day == "Friday")
                {
                    price = numOfPeople * 15;
                }
                else if (day == "Saturday")
                {
                    price = numOfPeople * 20;
                }
                else//Sunday
                {
                    price = numOfPeople * 22.5;
                }
                if (numOfPeople>=10 && numOfPeople<=20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
