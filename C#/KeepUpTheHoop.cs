// Language: C#
// Level: 8kyu
// Name of Problem: Keep up the hoop

// Instructions: Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him.
// Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message :)

// -If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
// -If he doesn't get 10 hoops, return the string "Keep at it until you get it".

// Solution:
public class Kata
{
  public static string HoopCount(int n)
  {
    if (n >= 10) {
    return "Great, now move on to tricks";
    } else {
    return "Keep at it until you get it";
    }
  }
}

// Sample Tests Passed:
// using NUnit.Framework;
// using System;

// [TestFixture]
// public class Tests
// {
//   [Test]
//   public static void FixedTest()
//   {
//     Assert.AreEqual("Keep at it until you get it", Kata.HoopCount(6), "Should work for 6");
//     Assert.AreEqual("Great, now move on to tricks", Kata.HoopCount(22), "Should work for 22");
//   }
// }