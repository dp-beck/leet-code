using leet_code;
using Microsoft.VisualBasic;

// Two Sum
var twoSumSolution = new TwoSumSolution();
var result = twoSumSolution.TwoSumBrute(new int[] { 2, 7, 11, 15 }, 9);

Console.WriteLine("Two Sum");
Console.WriteLine("Input: [2, 7, 11, 15], Target: 9");
Console.WriteLine($"Result: [{result[0]}, {result[1]}]");
Console.WriteLine();

// Running Sum of 1d Array
var runningSumOf1dArray = new RunningSumOf1dArray();
var runningSumResult = runningSumOf1dArray.RunningSum(new int[] { 1, 2, 3, 4 });

Console.WriteLine("Running Sum of 1d Array");
Console.WriteLine("Input: [1, 2, 3, 4]");
Console.WriteLine($"Result: [{string.Join(", ", runningSumResult)}]");
Console.WriteLine();

// FizzBuzz
var fizzBuzz = new FizzBuzz();
var fizzBuzzResult = fizzBuzz.FizzBuzzSolution(15);

Console.WriteLine("FizzBuzz");
Console.WriteLine("Input: 15");
Console.WriteLine($"Result: [{string.Join(", ", fizzBuzzResult)}]");
Console.WriteLine();

// Is Unique String
var isUniqueStringSolution = new IsUniqueStringSolution();
Console.WriteLine("Alabama is a unique string: " + isUniqueStringSolution.IsUniqueString("Alabama"));
Console.WriteLine("Taco is a unique string: " + isUniqueStringSolution.IsUniqueString("Taco"));

// Merge Sorted Array 1
System.Console.WriteLine("Merge Sorted Array 1");
var mergeSortedArray = new MergeSortedArray();
var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var nums2 = new int[] { 2, 5, 6 };
mergeSortedArray.Merge(nums1, 3, nums2, 3);
foreach (var num in nums1)
{
    Console.Write(num + " ");
}

// Merge Sorted Array 2
System.Console.WriteLine("\nMerge Sorted Array 2");
nums1 = new int[] { 4, 5, 6, 0, 0, 0 };
nums2 = new int[] { 1, 2, 3 };
mergeSortedArray.Merge(nums1, 3, nums2, 3);
foreach (var num in nums1)
{
    Console.Write(num + " ");
}

// Merge Sorted Array 3
System.Console.WriteLine("\nMerge Sorted Array 3");
nums1 = new int[] { 0 };
nums2 = new int[] { 1 };
mergeSortedArray.Merge(nums1, 0, nums2, 1);
foreach (var num in nums1)
{
    Console.Write(num + " ");
}

// Remove Element 1
System.Console.WriteLine("\nRemove Element");
var removeElement = new RemoveElement();
var removeElementResult1 = removeElement.Remove(new int[] { 3, 2, 2, 3 }, 3);
Console.WriteLine("Input: [3, 2, 2, 3], Target: 3");
Console.WriteLine($"Result: {removeElementResult1}");


// Remove Element 2
System.Console.WriteLine("\nRemove Element");
var removeElementResult2 = removeElement.Remove(new int[] { 0,1,2,2,3,0,4,2}, 2);
Console.WriteLine("Input: [0, 1, 2, 2, 3, 0, 4, 2], Target: 2");
Console.WriteLine($"Result: {removeElementResult2}");

// Remove Duplicsates
var removeDuplicates = new RemoveDuplicates();
var removeDuplicatesResult = removeDuplicates.RemoveDuplicatesSolution(new int[] { 0,0,1,1,1,2,2,3,3,4 });
Console.WriteLine("Remove Duplicates");
Console.WriteLine("Input: [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]");
Console.WriteLine($"Result: {removeDuplicatesResult}");

// 0, 1, 2, 3, 4, 2, 2, 3, 3, 4

// Majority Element
var majorityElement = new MajorityElement();
var result1 = majorityElement.MajorityElementSolution(new int[] { 3, 2, 3 });
