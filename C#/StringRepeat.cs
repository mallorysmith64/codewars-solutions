// Language: C#
// Level: 8kyu
// Name of Problem: String repeat

// Instructions: Write a function called repeatString which repeats the given String src exactly count times.

// Examples: 
// repeatStr(6, "I") // "IIIIII"
// repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"

// Solution 1:
using System;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return String.Concat(Enumerable.Repeat(s, n));
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
//     public void MyTest()
//     {
//       Assert.AreEqual("***", Program.repeatStr(3, "*"));
//     }
//   }
// }