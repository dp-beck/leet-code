using System.Linq.Expressions;

namespace leet_code;

public class MergeSortedArray
{
    // m == length of nums1
    // n == length of nums2
    // nums1 == [1, 2, 3, 0, 0, 0]
    // nums2 == [2, 5, 6]
    // Output: [1, 2, 2, 3, 5, 6]
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            } else
            {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >=0)
        {
            nums1[k--] = nums2[j--];
        }

    }
};