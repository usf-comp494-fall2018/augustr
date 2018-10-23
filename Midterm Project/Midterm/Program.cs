using System;
using System.IO;
using CalculationsLib;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //First created string that holds the directory that the program is running in
            string access = Directory.GetCurrentDirectory();
            //Adds File name to directory
            var custom = new string[]
            {
                access, "CalcInput.txt"
            };

            string dir = Path.Combine(custom);
            //read file in array
            string[] numbers = File.ReadAllLines(dir);

            //int number = numbers.Length;
            ///*This was used to test if array held elements*/
            //Console.WriteLine($"{number}");

            //Converted string array to double in order to use Calculations methods
            double[] theNum = Array.ConvertAll(numbers, double.Parse);

            var holder = new Calculations();

            double mean = holder.Mean(theNum);
            double median = holder.Median(theNum);

            ////Below line was to test to make sure values were correct
            //Console.WriteLine($"The median is {median} and the mean is {mean}.");

            //Creating output file

            var customFolder = new string[]
            {
                access, "CalcOutput.txt"
            };

            ////Creating directory for output file
            //string direct = Path.Combine(customFolder);
            //Console.WriteLine($"THis is the directory: {direct}.");

            //Creating Output file
            StreamWriter textWriter = new StreamWriter("CalcOutput.txt");

            for (int i = 0; i < theNum.Length; i++)
            {
                textWriter.WriteLine(theNum[i]);
            }

            //Writing to output file
            textWriter.WriteLine("\nThe above set of numbers were the numbers we stored in an array.");
            textWriter.WriteLine($"The mean for this set of numbers was {mean}. That's a long decimal.");
            textWriter.WriteLine($"The median for the set of numbers above is {median}.");

            textWriter.Close();
        }
    }
}
