using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyboardP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());

            int countHeadset = 0;
            int countMouseset = 0;
            int countKeyboard = 0;
            int countDisplay = 0;

            double priceHead = 0;
            double priceMouse = 0;
            double priceKeyboard = 0;
            double priceDisplay = 0;

            for (int game = 2; game <= lostGames; game++)
            {
                if (game%2==0)
                {
                    countHeadset++;
                }
                if (game%3==0)
                {
                    countMouseset++;
                }
                if (game%2==0 && game%3==0)
                {
                    countKeyboard++;
                    if (countKeyboard%2==0)
                    {
                        countDisplay++;
                    }
                }
                
            }
            priceHead = countHeadset * headP;
            priceMouse = countMouseset * mouseP;
            priceKeyboard = countKeyboard * keyboardP;
            priceDisplay = countDisplay * displayP;
            double sumAll = priceHead + priceMouse + priceKeyboard + priceDisplay;

            Console.WriteLine($"Rage expenses: {sumAll:f2} lv.");

        }
    }
}
