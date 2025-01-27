using System;

namespace leet_code;

public class RemoveDuplicates
{
    public int RemoveDuplicatesSolution(int[] nums) {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
                    
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    nums[i+1] = nums[j];
                    count++;
                    break;
                }

                if (j == nums.Length - 1)
                {
                    return count + 1;
                }
            }
        }
        return count + 1;  
    }
}
