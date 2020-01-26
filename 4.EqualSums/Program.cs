using System;

namespace _4.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            for (int i = numOne; i <=numTwo; i++)
            {
                string current = i.ToString();
               int odd = 0;
                int even = 0;
                for (int j = 0; j <current.Length; j++)
                {
                    int currentNumber = int.Parse(current[j].ToString());
                    if(j%2==0)
                    {
                        even += currentNumber;
                    }
                    else
                    {
                        odd += currentNumber;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i+" ");
                }

            }
            
        }
    }

}
