using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodeSample.Algorithms
{
    public class MergeSortedStrings
    {

       public class MergeSortedStringsResult
       {
            public bool isSuccessful { get; set; }
            public string Message { get; set; }

       }
        //Add ValidStringResult obj here and pull out all validation into a separate method.

        public MergeSortedStringsResult MergeSortedArrays(string inputA, string inputB)
        {
            var result = new MergeSortedStringsResult();
            //if(inputA.Length != inputB.Length)
            //{
            //    result.isSuccessful = false;
            //    result.Message = $"Both sets must have the same number of digits. Your first set was {inputA.Length} & your second set was {inputB.Length}.";
            //    return result;
            //}

            //check that a & b are not whitespace
            bool isNotValidA = string.IsNullOrEmpty(inputA);
            bool isNotValidB = string.IsNullOrWhiteSpace(inputB);

            if(!isNotValidA && !isNotValidB)
            {
                //check if both a & b are parsable
                var isParsableA = Int32.TryParse(inputA, out int parsedValA);
                var isParsableB = Int32.TryParse(inputB, out int parsedValB);

                if (isParsableA && isParsableB)
                {
                    //get my variables into arrays
                    //convert input to array of chars
                    var charArray1 = inputA.ToCharArray();
                    var charArray2 = inputB.ToCharArray();
                    //convert char array to array of ints
                    int[] arr1 = Array.ConvertAll(charArray1, c => (int)Char.GetNumericValue(c));
                    int[] arr2 = Array.ConvertAll(charArray2, c => (int)Char.GetNumericValue(c));

                    //get the length of both
                    var lengthOf1 = arr1.Length;
                    var lengthOf2 = arr2.Length;

                    //create a new array to hold merged arrays
                    var arr3 = new int[lengthOf1 + lengthOf2];

                    var mergedArray = SortArrays(arr1, arr2, lengthOf1, lengthOf2, arr3);
                    var mergedArrayStr = "";
                    foreach(var element in mergedArray)
                    {
                        mergedArrayStr += element.ToString();
                    }

                    result.isSuccessful = true;
                    result.Message = $"Here is your result. :)\nMerged & Sorted Array: {mergedArrayStr}";

                }
                else
                {
                    result.isSuccessful = false;
                    result.Message = "Hey! Those aren't numbers! You better do it right this time. >:(\n";
                }
            }
            else
            {
                result.isSuccessful = false;
                result.Message = "Hey! You didn't enter anything! That's not fair. >:(\n";
            }

            return result;
        }

        public int[] SortArrays( int[] arr1, int[] arr2, int lengthOf1, int lengthOf2, int[] mergedArr)
        {
           
            //indices
            int index1 = 0, index2 = 0, indexMerged = 0;

            //This only accounts for arrays that are the same size. How would I account for arrays of different sizes?
            //Traverse both arrays
            //while index1 is less than arr1 starting length && index2 is less than arr2 starting length > check that you're still in range
            while (index1 < arr1.Length-1 && index2 < arr2.Length-1)
            {
                //Check if the value of the current index of arr1 is smaller than the value of the current index of arr2
                if (arr1[index1] < arr2[index2])
                {
                    //if it is store arr1 value in current mergedArr index
                    mergedArr[indexMerged] = arr1[index1];

                    //increment both
                    indexMerged++;
                    index1++;
                }
                else
                {
                    //Otherwise, store arr2 value in current mergedArr index (this accounts for both cases: is not greater than or is equal
                    mergedArr[indexMerged] = arr2[index2];

                    //increment
                    indexMerged++;
                    index2++;
                }
            }
            //after index1 is larger than starting length of arr1 OR index2 is larger than starting length of arr2

            //store the remaining elements of arr1
            while (index1 < arr1.Length)
            {
                //store
                mergedArr[indexMerged] = arr1[index1];

                //increment
                indexMerged++;
                index1++;
            }

            //store remaining elements of arr2
            while (index2 < arr2.Length)
            {
                //store
                mergedArr[indexMerged] = arr2[index2];

                //increment
                indexMerged++;
                index2++;
            }

            return mergedArr;
        }
    }
}
