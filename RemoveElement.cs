using System;

namespace leet_code;

public class RemoveElement
{
    // [3, 2, 2, 3], 3
    // [0,1,2,2,3,0,4,2], 2
    // [1], 1

    public int Remove(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;
        //Number of Elements in num that are not equal to val
        int k = 0;

        foreach(int num in nums)
        {
            if (num != val)
                k++;
        }

        if (nums.Length == 0 )
        {
            return i;
        }

        if (nums.Length == 1 & nums[0] == val)
        {
            return i;
        }

        while (i <= j )
        {
            if (nums[i] == val)
            {
                while (j > 0 && nums[j] == val)
                {
                    j--;
                }
                nums[i] = nums[j];
                j--;
            }
        
            i++;
        }
        return k;

    }
}
