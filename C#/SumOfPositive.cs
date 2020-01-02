// Language: C#
// Level: 8kyu
// Name of Problem: Sum of positive

// Instructions: You get an array of numbers, return the sum of all of the positives ones.

// Example:
// [1,-4,7,12] => 1 + 7 + 12 = 20
// Note: if there is nothing to sum, the sum is default to 0.

// Solution:
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    //First: check numbers are positive
    //Second: use aggregate to add the numbers together, 0 is the starting point
    var array = arr.Where(i => i > 0).Aggregate(0, (pos, next) => pos + next);
    return array;
  }
}

// Sample Tests Passed:
// using NUnit.Framework;
// using System;

// [TestFixture]
// public class Tests
// {
//   [Test]
//   [TestCase(new int[]{1, 2, 3, 4, 5}, ExpectedResult=15)]
//   [TestCase(new int[]{1, -2, 3, 4, 5}, ExpectedResult=13)]
//   [TestCase(new int[]{-1, 2, 3, 4, -5}, ExpectedResult=9)]
//   [TestCase(new int[]{}, ExpectedResult=0)]
//   [TestCase(new int[]{-1, -2, -3, -4, -5}, ExpectedResult=0)]
//   public static int ExampleTest(int[] arr)
//   {
//     return Kata.PositiveSum(arr);
//   }
// }