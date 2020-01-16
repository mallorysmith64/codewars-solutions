// Language: C#
// Level: 7kyu
// Name of Problem: Fizz / Buzz

// Instructions: Write a function that takes an integer and returns an array [A, B, C], where A is the number of multiples of 3 (but not 5) below the given integer, B is the number of multiples of 5 (but not 3) below the given integer and C is the number of multiples of 3 and 5 below the given integer.

// Examples: 
// solution(20) should return [5, 2, 1]

// Solution 1:
using System.Linq;

public class Kata
{
  public static int[] Solution(int n)
  {
  return new int[]
    {
  Enumerable.Range(1,n - 1).Count(x => x % 3 == 0 && x % 5 != 0),
  Enumerable.Range(1,n - 1).Count(x => x % 3 != 0 && x % 5 == 0),
  Enumerable.Range(1,n - 1).Count(x => x % 3 == 0 && x % 5 == 0),
    };
  }
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class SolutionTest
//   {
//     private static object[] sampleTestCases = new object[]
//     {
//       new object[] {20,  new int[] {5, 2, 1}},
//       new object[] {2,   new int[] {0, 0, 0}},
//       new object[] {30,  new int[] {8, 4, 1}},
//       new object[] {300, new int[] {80, 40, 19}},
//     };
  
//     [Test, TestCaseSource("sampleTestCases")]
//     public void SampleTest(int number, int[] expected)
//     {
//       Assert.AreEqual(expected, Kata.Solution(number));
//     }
//   }
// }