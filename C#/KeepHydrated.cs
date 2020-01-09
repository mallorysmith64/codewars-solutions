// Language: C#
// Level: 8kyu
// Name of Problem: Keep Hydrated!

// Instructions: Nathan loves cycling.
// Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
// You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.

// Examples:
// time = 3 ----> litres = 1
// time = 6.7---> litres = 3
// time = 11.8--> litres = 5

using System;

// Solution 1:
//don't forget to uncomment "using System;"

// using System;
public class Kata
{
  public static int Litres(double time)
  {
return (int) (time/2);
  }
}

// Solution 2:
//don't forget to uncomment "using System;"

// using System;
public class Kata
{
  public static int Litres(double time)
  {
    return (int) (time * 0.5);
  }
}

// Sample Tests Passed:
// using NUnit.Framework;
// using System;

// [TestFixture]
// public class Tests
// {
//   [Test]
//   public static void Test1()
//   {
//     Assert.AreEqual(1, Kata.Litres(2));
//   }
  
//   [Test]
//   public static void Test2()
//   {  
//     Assert.AreEqual(0, Kata.Litres(1.4));
//   }
  
//   [Test]
//   public static void Test3()
//   {
//     Assert.AreEqual(6, Kata.Litres(12.3));
//   }
  
//   [Test]
//   public static void Test4()
//   {
//     Assert.AreEqual(0, Kata.Litres(0.82));
//   }
  
//   [Test]
//   public static void Test5()
//   {
//     Assert.AreEqual(5, Kata.Litres(11.8));
//   }
  
//   [Test]
//   public static void Test6()
//   {
//     Assert.AreEqual(893, Kata.Litres(1787));
//   }
//   [Test]
//   public static void Test7()
//   {
//     Assert.AreEqual(0, Kata.Litres(0));
//   }

// }