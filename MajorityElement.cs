using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Given an array nums of size n, return the majority element.

// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 
// Example 1:

// Input: nums = [3,2,3]
// Output: 3
// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
 

// Constraints:

// n == nums.length
// 1 <= n <= 5 * 104
// -109 <= nums[i] <= 109
 

// Follow-up: Could you solve the problem in linear time and in O(1) space?

namespace leet_code
{
    public class MajorityElement
    {
        public int MajorityElementSolution(int[] nums) {
        // Get the Length / 2
        // Create a Dictionay (Num: NumTimes)
        // Loop through nums and add count to dictionary
        // When one is more than n/2 then stop and return that one
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        int answer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!numDict.ContainsKey(nums[i]))
            {
                numDict.Add(nums[i], 1);
            } else 
            {
                numDict[nums[i]]++;
            }

            if (numDict[nums[i]] > nums.Length / 2)
            {
                answer = nums[i];
                break;
            }
            
        }
        return answer;
    }
    }
}