using System;

namespace leet_code;

// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

// Return the running sum of nums.

 
public class RunningSumOf1dArray
{
    public int[] RunningSum(int[] nums) 
    {
        int[] result = new int[nums.Length];
        result[0] = nums[0];
        for (int i = 1; i < nums.Length; i++ )
        {
            result[i] = nums[i] + result[i-1]; 
        }
        return result;
    }

}
