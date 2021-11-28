using ConsoleCodeSample.Algorithms;
using System;

namespace ConsoleCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the directory
            MethodDirectory.HelloDirectory();
            
            //execute selection
            MethodDirectory.ExecuteSelection(Console.ReadLine());

            Console.WriteLine("Would you like to make another selection?\nEnter Y + ENTER for yes.\nEnter N + ENTER to exit console.");
            
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    MethodDirectory.HelloDirectory();
                    MethodDirectory.ExecuteSelection(Console.ReadLine());
                    break;
                case "n":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Sorry, that wasn't one of the options. Try again.  (0.0) ");
                    //add recursion?
                    break;
            }

        }
    }
}
