using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodeSample.Algorithms
{
    public class CommonItem
    {
        

        public String[] SplitStrings(string userInput)
        {
            String[] stringArray = userInput.Split(",");

            return stringArray;
        }

        //O(a*b) > Bad time complexity rating
        //O(1) > Excellent space complexity
        public bool BadContainsCommonItem(string[] arr1, string[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

       
        //O(a+b) > Better time complexity
        //O(a) > Okay space complexity
        public bool ContainsCommonItem(string[] arr1, string[] arr2)
        {
            /* **** BETTER SOLUTION *************************************************************************
             * array 1 ==> obj (hashtable?) {
             * a: true,
             * b: true, etc.
             * }
             * array2[index] === obj.properties
             */

            /* **** STEPS ***********************************************************************************
             * loop through first array and create object (hashtable?) & create obj where prop == items in the array
             * loop through second array and check if item in second array exists on created object
             */

            return false;
        }
        //!!! Google better ways to handle arrays in C#

    }
}
