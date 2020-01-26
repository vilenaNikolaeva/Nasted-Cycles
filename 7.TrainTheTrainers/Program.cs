using System;

namespace _7.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juriPeople = int.Parse(Console.ReadLine());
            double totalgrade = 0;
            string finish = Console.ReadLine();
            double studentgrade = 0;
            double counter = 0;
            double totalStudentsGrates = 0;


            while (finish != "Finish")
            {
                totalgrade = 0;
                for (double grade = 1; grade <= juriPeople; grade++)
                {
                    studentgrade = double.Parse(Console.ReadLine());
                    totalStudentsGrates += studentgrade;
                    studentgrade += totalgrade;
                    totalgrade = studentgrade;
                    counter++;
                    if (grade == juriPeople)
                    {
                        totalgrade = totalgrade / juriPeople;
                        break;
                    }
                }
                if (finish != "Finish")
                {
                    Console.WriteLine($"{finish} - {totalgrade:F2}. ");
                }
                finish = Console.ReadLine();
                if (finish == "Finish")
                {

                    Console.Write($"Student's final assessment is {totalStudentsGrates / counter:F2}.");
                }
            }
        }
    }
}

