using leet_code;

// Two Sum
var twoSumSolution = new TwoSumSolution();
var result = twoSumSolution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

Console.WriteLine("Two Sum");
Console.WriteLine("Input: [2, 7, 11, 15], Target: 9");
Console.WriteLine($"Result: [{result[0]}, {result[1]}]");

// Running Sum of 1d Array
var runningSumOf1dArray = new RunningSumOf1dArray();
var runningSumResult = runningSumOf1dArray.RunningSum(new int[] { 1, 2, 3, 4 });

Console.WriteLine("Running Sum of 1d Array");
Console.WriteLine("Input: [1, 2, 3, 4]");
Console.WriteLine($"Result: [{string.Join(", ", runningSumResult)}]");