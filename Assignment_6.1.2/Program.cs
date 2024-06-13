/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.
Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:
Input: nums = [0]
Output: [0]
*/

using System.Runtime.ExceptionServices;

namespace Assignment_6._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 }; // hard coded an array 
            int temp = 0; // using a temp as index that is incremented to assign valid number to as we iterate


            for (int i = 0; i < nums.Length; i++) // iterating through the array starting at index i for the length of the array
            {
                
                if (nums[i] != 0) // if the nums[i] element value is not 0 then assign directed below
                {
                    nums[temp++] = nums[i]; // the first non zero will be assigned to temp ie 1 for the first iteration into nums[temp++] which is nums[0]
                                            //second iteration 3 will be assinged to nums[temp++] which is nums[1] due to temp++ increasing as valid numbers are found in the array
                                            // second iteration 12 will be assinged to nums[temp++] which is nums[2] due to temp++ increasing as valid numbers are found in the array
                                            // result is array {1, 3, 12, 3, 12} because we have replaced all zeros with values through incrementing the index with temp

                }

            }

            for (; temp < nums.Length; temp++) // now we are goting to iterate through the array when temp < nums.Length this means we start at index 3. then increment temp. 
                                                // this places zeros in the remaining elements that did not have valid numbers in the previous iteration.
                                                //Note: initialization section omitted because temp alreacy initialized and incremented in previous loop therefore no need to initialize again
            {
                nums[temp] = 0; //assigns 0 to index 3, increments then will assign 0 to index 4.
            }
            

            foreach (int num in nums) // print all elements in the array after they have been replaced above. 
            {
                Console.WriteLine(num);
            }


        }
    }
}
