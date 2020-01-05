// Language: C#
// Level: 8kyu
// Name of Problem: Century From Year

// Instructions: The first century spans from the year 1 up to and including the year 100, The second - from the year 101 up to and including the year 200, etc.
// Given a year, return the century.

// Examples: 
// centuryFromYear(1705)  returns (18)
// centuryFromYear(1900)  returns (19)
// centuryFromYear(1601)  returns (17)
// centuryFromYear(2000)  returns (20)

using System;

// Solution 1:
// tip 1: don't forget to uncomment "using System;" for this solution to work!

// using System;
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    return (int)Math.Floor((double)1 + (year - 1) / 100);
  }
}

// Solution 2:
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    return (year - 1) / 100 + 1;
  }
}

// Solution 3:
// tip 1: don't forget to uncomment "using System;" for this solution to work!

// using System;
public static class Kata
{
  public static double СenturyFromYear(double year)
  {
    return Math.Ceiling(year/100);
  }
}

// Solution 4:
// tip 1: don't forget to uncomment "using System;" for this solution to work!

// using System;
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    int century = (int)Math.Floor((double)year / 100);
    int decade = year % 100;
  
    if (decade > 0) {
      return century + 1;
    }
      return century;
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
//     public void SampleTest()
//     {
//      Assert.AreEqual(18, Kata.СenturyFromYear(1705));
//      Assert.AreEqual(19, Kata.СenturyFromYear(1900));
//      Assert.AreEqual(17, Kata.СenturyFromYear(1601));
//      Assert.AreEqual(20, Kata.СenturyFromYear(2000));
//     }
//   }
// }