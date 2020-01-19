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

// Solution 2:
// Hint: when "System.Text;" is missing from the solution, this error will occur:
//"The type or namespace name 'StringBuilder' could not be found (are you missing a using directive or an assembly reference?)"
//To avoid this error, don't forget to uncomment "using System.Text;" from the solution below

// using System.Text;
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
       return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
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