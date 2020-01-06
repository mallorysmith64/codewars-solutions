// Language: C#
// Level: 7kyu
// Name of Problem: Sum of Triangular Numbers

// Instructions: Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.
// Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."
// Triangular Numbers cannot be negative so return 0 if a negative number is given.

// Examples:
// [01]
// 02 [03]
// 04 05 [06]
// 07 08 09 [10]
// 11 12 13 14 [15]
// 16 17 18 19 20 [21]
// e.g. If 4 is given: 1 + 3 + 6 + 10 = 20.

// Solution 1:
  public class Kata
{
  public static int SumTriangularNumbers(int n)
  {
  int sum = 0;
  for (var i = 1; i <= n; i++) {
    sum += i * (i + 1) / 2;
    }
  return sum;
  }
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class SolutionTest
//   {
//     [Test]
//     public void BasicTests()
//     {
//       Assert.AreEqual(56, Kata.SumTriangularNumbers(6));
//       Assert.AreEqual(7140, Kata.SumTriangularNumbers(34));
//       Assert.AreEqual(0, Kata.SumTriangularNumbers(-291));
//       Assert.AreEqual(140205240, Kata.SumTriangularNumbers(943));
//       Assert.AreEqual(0, Kata.SumTriangularNumbers(-971));
//     }
//   }
// }