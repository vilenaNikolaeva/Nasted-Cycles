using System;

namespace _5.EqualSumsLeftOrRightPosition
{
    class Program
    {
        private static object stringToNumber;

        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int current = 0;

            for (int i = numOne; i <= numTwo; i++)
            {
                current = i;
                int fifthDigit = current % 10;
                current = current/ 10;
                int fourthDigit = current % 10;
                current = current/ 10;
                int thirdDigit = current % 10;
                current = current/ 10;
                int secondDigit = current % 10;
                current = current/ 10;
                int firstDigit = current % 10;
                current =current / 10;

                leftSum = firstDigit + secondDigit;
                rightSum = fifthDigit + fourthDigit;

                if (leftSum < rightSum)
                {
                    leftSum = leftSum + thirdDigit;
                }
                else if (rightSum < leftSum)
                {
                    rightSum = rightSum + thirdDigit;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i +" ");
                }
            }
        }
    }
}
