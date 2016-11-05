using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {

            IGradeTracker book = CreateGradeBook(); 
            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);

            Console.ReadKey();
        }

        

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.averageGrade);
            WriteResult("Highest", (int)stats.highestGrade);
            WriteResult("Lowes", (int)stats.lowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrade(outputFile);
                outputFile.Dispose();
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(45.5f);
            book.WriteGrade(Console.Out);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + " : " + result);
        }

        //params convert argument to array
        static void WriteResult(string description , float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + " : " + result);
        }



    }
}
