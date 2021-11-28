using ConsoleCodeSample.Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodeSample
{
    public static class MethodDirectory
    {

        public static void HelloDirectory()
        {
            Console.WriteLine("Hello World!\n");
            Console.WriteLine($"Please select the index of your desired method & hit enter.\n" +
                                "0: Find Common Item - 2 inputs\n" +
                                "1: Uno Reverse - 1 input\n" +
                                "2: Merge Ordered Numbers (inputs under construction)");
        }

        public static void ExecuteSelection(string userSelection)
        {

            switch (userSelection)
            {
                case "0":
                    Console.WriteLine("Please enter the two sets of digits you would like to compare & hit enter.\nEx: 12345, 098765");
                    var userInput0 = Console.ReadLine();
                    var ci = new CommonItem();
                    //finish implementing user input
                    //Console.WriteLine($"This should be true: {ci.ContainsCommonItem(array1, array2)}");
                    //Console.WriteLine($"This should be false: {ci.ContainsCommonItem(array1, array3)}");
                    break;

                case "1":
                    var reverseString = new ReverseString();
                    Console.WriteLine("Please enter your desired text & hit enter.");
                    string userInput1 = Console.ReadLine();
                    Console.WriteLine(reverseString.ReverseStringFunc(userInput1));
                    break;

                case "2":
                    MergeSortedStrings();
                    break;

                default:
                    break;
            }

        }

        public static void MergeSortedStrings()
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                var mergeSortedStrings = new MergeSortedStrings();
                Console.WriteLine("Please enter your first set of digits. Both sets must have the same number of digits.");
                string userInput2a = Console.ReadLine();
                Console.WriteLine("Please enter your second set of digits. Both sets must have the same number of digits.");
                string userInput2b = Console.ReadLine();
                Console.WriteLine(mergeSortedStrings.MergeSortedArrays(userInput2a, userInput2b).Message);

                Console.WriteLine("\nWould you like to play again?\nY + enter = yes\nN + enter = no");
                if(Console.ReadLine().ToLower() == "n")
                {
                    keepLooping = false;
                }
            }

        }
    }
}
