using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Book book2 = new Book("Created new instace of class book");
             Ibook book = new DiskBook("Sreelekha Grade Book");
            book.GradeAdded += OnGradeAdded;


            // book.grades.Add(7.2)
            // double[] numbers = new double[3] { 1.2,4.2,3.4};
            //List<double> grades = new List<double>() { 1.2,3.4,5.5};
            //grades.Add(6.6);

            EnterGrades(book);
            var stats = book.Getstatistics();
            Console.WriteLine($"The low grade: {stats.lowgrade}");
            Console.WriteLine($"The high grade: {stats.highgrade}");
            Console.WriteLine($"The average grade: {stats.average:N1}");
            Console.WriteLine($"The letter grade is: {stats.letter}");
            Console.ReadLine();

        }

        private static void EnterGrades(Ibook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.Addgrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            };
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Grade Has been Added");
        }

    }
}
