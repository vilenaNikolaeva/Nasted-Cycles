using System;

namespace _8.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyMaxFishNum = int.Parse(Console.ReadLine());
            string fishName = "";
            double sum = 0;
            double payFishPrice = 0;
            int count = 0;


            while (count < dailyMaxFishNum)
            {
                fishName = Console.ReadLine();
                if (fishName != "Stop")
                {
                    count++;
                    double fishiKg = double.Parse(Console.ReadLine());
                    sum = 0;
                    for (int i = fishName.Length - 1; i >= 0;i--)
                    {
                        int symbol = fishName[i];
                        sum += symbol;
                    }
                    if (count % 3 == 0)
                    {
                        payFishPrice = payFishPrice + (sum / fishiKg);
                    }
                    else 
                    {
                        payFishPrice = payFishPrice - (sum / fishiKg);
                    }
                }

                 if (fishName == "Stop")
                {
                    if (payFishPrice <= 0)
                    {
                        Console.WriteLine($"Lyubo lost {Math.Abs(payFishPrice):f2} leva today.");
                    }
                    else
                    {
                        Console.WriteLine($"Lyubo's profit from {count} fishes is {Math.Abs(payFishPrice):f2} leva.");
                    }

                    break;
                }
                else if (count == dailyMaxFishNum)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    if (payFishPrice > 0)
                    {
                        Console.WriteLine($"Lyubo's profit from {count} fishes is {Math.Abs(payFishPrice):f2} leva.");
                    }
                    else
                    {
                        Console.WriteLine($"Lyubo lost {Math.Abs(payFishPrice):f2} leva today.");
                    }

                    break;
                }
            }
        }
    }
}


