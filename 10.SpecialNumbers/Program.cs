using System;

namespace _10.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <=9; k++)
                {
                    for (int l = 1; l <=9; l++)
                    {
                        for (int m = 1; m <=9; m++)
                        {
                            if (number%i==0 && number%k==0 && number%l==0&&number%m==0)
                            {
                                Console.Write($"{i}{k}{l}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
