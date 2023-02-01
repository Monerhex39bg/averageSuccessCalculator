using System;

namespace averageSuccessCalculatorNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ВХОД
            Console.Write("Напиши броят на оценките: ");
            double numberOfGrades = double.Parse(Console.ReadLine());

            //ДОПЪЛНИТЕЛНИ ПРОМЕНЛИВИ
            double counter = 0;

            //ИЗЧИСЛЕНИЯ И ИЗХОД
            if (numberOfGrades <= 0 || numberOfGrades == 1)
            {
                Console.WriteLine("Въвели сте число равно или по-малко от 1!");
            }
            else
            {
                for (double i = 0; i < numberOfGrades; i++)
                {
                    Console.Write("Напиши оценка: ");
                    double grade = double.Parse(Console.ReadLine());

                    counter += grade;
                }
                double averageSuccess = counter / numberOfGrades;
                Console.WriteLine($"Среден успех: {averageSuccess:f2}");
            }
        }
    }
}