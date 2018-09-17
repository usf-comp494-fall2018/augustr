using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Bob", "Dana", "Julie", "Sarah", "Fred", "Waldo", "Jenny", "Cathy" };
            int position = 0;
            bool found = false;
            int max = names.Length;


            for (int t = 0; t < max; t++)
            {
                if (names[t] == "Waldo")
                {
                    found = true;
                    break;
                }
                else
                {
                    position++;
                }
            }
            Console.WriteLine($"Waldo has been found at {position}.");
        }

           
        
    }
}
