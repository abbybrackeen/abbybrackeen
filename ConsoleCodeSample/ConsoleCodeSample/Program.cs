using ConsoleCodeSample.Algorithms;
using System;

namespace ConsoleCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Common Item Data ---> Edit to take user input
            string[] array1 = { "a", "b", "c", "x" };
            string[] array2 = { "z", "y", "x" };
            string[] array3 = { "d", "e", "f", "g" };


            Console.WriteLine("Hello World!");
            Console.WriteLine($"Please select the index of your desired method & hit enter.\n" +
                                "0: Find Common Item - 2 array input\n" +
                                "1: Uno Reverse - 1 string input");

            string userSelection = Console.ReadLine();
            //pull this out into another method
            switch (userSelection)
            {
                case "0":
                    Console.WriteLine("Please enter the two sets of digits you would like to compare & hit enter.\nEx: 12345, 098765");
                    var userInput2 = Console.ReadLine();
                    var ci = new CommonItem();
                    //finish implementing user input
                    Console.WriteLine($"This should be true: {ci.ContainsCommonItem(array1, array2)}");
                    Console.WriteLine($"This should be false: {ci.ContainsCommonItem(array1, array3)}");
                    break;

                case "1":
                    var reverseString = new ReverseString();
                    Console.WriteLine("Please enter your desired text & hit enter.");
                    string userInput1 = Console.ReadLine();
                    Console.WriteLine(reverseString.ReverseStringFunc(userInput1));
                    break;

                default:
                    break;
            }

            //add way to select again or exit
            Console.ReadLine();
        }
    }
}
