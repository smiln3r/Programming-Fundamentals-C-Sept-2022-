using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //1
                //4*3*2*1->24
                //5*4*3*2*1->120

            int numSt = int.Parse(Console.ReadLine());

            int copyNum = numSt;
            int useNum = 0;
            int integerInt = 1;
            int sumNum = 0;

            while (copyNum!=0)
            {
                    useNum = copyNum % 10;
                for (int i = useNum; i >= 1; i--)
                {
                    integerInt *= i;

                }
                sumNum+=integerInt;
                integerInt = 1;
                copyNum /= 10; 
            }

            if (numSt==sumNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            

            

        }
    }
}

