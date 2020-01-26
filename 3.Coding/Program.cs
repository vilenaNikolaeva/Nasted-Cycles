using System;

namespace _3.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length-1; i >= 0; i--)
            {
                char symbol = number[i];
                string toParse = symbol.ToString();
                int symbolAsNumber = int.Parse(toParse);
                char a = (char)(symbolAsNumber + 33);

                for (int k = 0; k < symbolAsNumber; k++)
                {
                    Console.Write(a);
                }

                if (symbolAsNumber == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
