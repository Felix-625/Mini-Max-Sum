using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
      // Sort the array
        arr.Sort();
        
        // Calculate the sum of the entire list
        long totalSum = arr.Sum(x => (long)x); // Use long to prevent overflow
        
        // The minimum sum is the total sum minus the largest number
        long minSum = totalSum - arr[arr.Count - 1];
        
        // The maximum sum is the total sum minus the smallest number
        long maxSum = totalSum - arr[0];
        
        // Print the result in the desired format
        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Result.miniMaxSum(arr);
    }
}
