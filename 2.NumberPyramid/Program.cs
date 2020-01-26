using System;

namespace _2.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool outOfN = false;

            for (int rows = 1; rows <= n; rows++)
            {

                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{current} ");
                    current++;
                    if (current > n)
                    {
                        outOfN = true;
                        break;
                    }
                }
                if (outOfN)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
