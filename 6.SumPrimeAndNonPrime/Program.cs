using System;

namespace _6.SumPrimeAndNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            int nonPrime = 0;
            bool isPrime = true;
            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (input != "stop")
                {
                    var inputNumber = int.Parse(input);
                    isPrime = true;

                    if (inputNumber < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    else
                    {
                        int m = inputNumber / 2;
                        for (int i = 2; i <= m; i++)
                        {
                            if (inputNumber % i == 0)
                            {
                                nonPrime += inputNumber;
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            prime += inputNumber;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}



