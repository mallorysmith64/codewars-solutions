// Language: C#
// Level: 8kyu
// Name of Problem: Tip Calculator

// Instructions: Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.
// Because you're a nice person, you always round up the tip, regardless of the service.

// You need to consider the following ratings:
// Terrible: tip 0%
// Poor: tip 5%
// Good: tip 10%
// Great: tip 15%
// Excellent: tip 20%

// The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:
// "Rating not recognised" in Javascript, Python and Ruby...
// ...or null in Java
// ...or -1 in C#

// Solution 1:
using System;

public class Kata
{
  public static int CalculateTip(double amount, string rating)
  {
  switch(rating.ToLower()) {
    case "terrible":
      return (int) Math.Ceiling(amount * 0);
    case "poor":
      return (int) Math.Ceiling(amount * 0.05);
    case "good":
      return (int) Math.Ceiling(amount * 0.10);
    case "great":
      return (int) Math.Ceiling(amount * 0.15);
    case "excellent":
      return (int) Math.Ceiling(amount * 0.20);
    default:
      return -1;
    }
  }
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;
  
//   [TestFixture]
//   public class SolutionTest
//   {
//     [Test, Description("Sample Tests")]
//     public void SampleTest()
//     {
//       Assert.AreEqual(4, Kata.CalculateTip(20, "Excellent"));
//       Assert.AreEqual(3, Kata.CalculateTip(26.95, "good"));
//     }
//   }
// }