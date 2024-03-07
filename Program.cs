using System;

namespace averageSuccessCalculatorNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Console.Write("Write the number of grades: ");
            double numberOfGrades = double.Parse(Console.ReadLine());

            //ADDITIONAL VARIABLES
            double counter = 0;

            //CALCULATIONS AND OUTPUT
            if (numberOfGrades <= 0 || numberOfGrades == 1)
            {
                Console.WriteLine("You entered a number equal to or less than 1!");
            }
            else
            {
                for (double i = 0; i < numberOfGrades; i++)
                {
                    Console.Write("Write a grade: ");
                    double grade = double.Parse(Console.ReadLine());

                    counter += grade;
                }
                double averageSuccess = counter / numberOfGrades;
                Console.WriteLine($"Average success: {averageSuccess:f2}");
            }
        }
    }
}