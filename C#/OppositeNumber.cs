// Level: 8kyu
// Name: Opposite number
// Instructions: Given a number, find its opposite

//Solution in C#
using System;

public class Kata
{
  public static int Opposite(int number)
  {
    return number = -number;
  }
}

// Sample Tests Passed:
// using NUnit.Framework;

//     [TestFixture]
//     public class MyTest
//     {
//         [Test]
//         public void Test_1()
//         {   
//             Assert.AreEqual(-1, Kata.Opposite(1));
//         }
//     }