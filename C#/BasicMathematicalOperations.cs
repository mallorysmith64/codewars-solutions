// Language: C#
// Level: 8kyu
// Name of Problem: Basic Mathematical Operations

// Instructions: Your task is to create a function that does four basic mathematical operations.
// The function should take three arguments - operation(string/char), value1(number), value2(number).
// The function should return result of numbers after applying the chosen operation.

// Examples
// basicOp('+', 4, 7)         // Output: 11
// basicOp('-', 15, 18)       // Output: -3
// basicOp('*', 5, 5)         // Output: 25
// basicOp('/', 49, 7)        // Output: 7

// Solution:
// use switch statement; make sure to have default or a thrown exception at the end
namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double a, double b)
    {
      switch (operation)
      {
      case '+': return a + b;
      case '-': return a - b;
      case '*': return a * b;
      case '/': return a / b;
      }
      return 0;
    }
  }
}

// Sample Tests Passed:
// namespace Solution
// {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class SolutionTest
//   {
//     [Test]
//     public void StaticTests()
//     {
//       Assert.AreEqual(Program.basicOp('+', 4, 7), 11);
//       Assert.AreEqual(Program.basicOp('-', 15, 18), -3);
//       Assert.AreEqual(Program.basicOp('*', 5, 5), 25);
//       Assert.AreEqual(Program.basicOp('/', 49, 7), 7);
//     }
//   }
// }