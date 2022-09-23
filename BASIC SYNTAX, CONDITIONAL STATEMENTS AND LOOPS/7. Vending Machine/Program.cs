using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sumMOney = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input=="Start")
                {
                    //while (input!="End")
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input=="End")
                        {
                            Console.WriteLine($"Change: {sumMOney:f2}");
                            break;
                        }
                        if (input=="Nuts")
                        {
                            sumMOney -= 2;
                            if (sumMOney>=0)
                            {
                                Console.WriteLine("Purchased nuts");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                sumMOney += 2;
                            }
                        }
                        else if (input=="Water")
                        {
                            sumMOney -= 0.7;
                            if (sumMOney >= 0)
                            {
                                Console.WriteLine("Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                sumMOney += 0.7;
                            }
                        }
                        else if (input=="Crisps")
                        {
                            sumMOney -= 1.5;
                            if (sumMOney >= 0)
                            {
                                Console.WriteLine("Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                sumMOney += 1.5;
                            }
                        }
                        else if (input == "Soda")
                        {
                            sumMOney -= 0.8;
                            if (sumMOney >= 0)
                            {
                                Console.WriteLine("Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                sumMOney += 0.8;
                            }
                        }
                        else if (input == "Coke")
                        {
                            sumMOney -= 1.0;
                            if (sumMOney >= 0)
                            {
                                Console.WriteLine("Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                sumMOney += 1.0;
                            }
                        }
                        
                    }
                }
                //double convInput;
                //double.TryParse(input, out convInput);


                int convInputt = int.Parse(input);
                double convInput = convInputt;

                if (convInput==0.1||convInput==0.2||convInput==0.5||convInput==1||convInput==2)
                {
                    
                    sumMOney += convInput;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {convInput}");
                }
                
                


                if (input == "End")
                {
                    Console.WriteLine($"Change: {sumMOney}");
                    break;
                }
            }
            

        }
        
    }
}
