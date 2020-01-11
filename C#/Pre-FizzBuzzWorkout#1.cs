// Language: C#
// Level: 8kyu
// Name of Problem: Pre-FizzBuzz Workout #1

// Instructions: This is the first step to understanding FizzBuzz.

// Examples: 
// Your inputs: a positive integer, n, greater than or equal to one. n is provided, you have NO CONTROL over its value.
// Your expected output is an array of positive integers from 1 to n (inclusive).

// Solution 1:
//don't forget to uncomment "using System.Linq;" for solution to work

// using System.Linq;
public class Kata
{
  public static int[] PreFizz(int n) 
  {
    return Enumerable.Range(1, n).ToArray();
  }
}

// Solution 2:
//don't forget to uncomment "using System.Linq;" for solution to work

// using System.Linq;
public class Kata
{
  public static int[] PreFizz(int n) 
  {
    int[] buzz = Enumerable.Range(1, n).ToArray();
        return buzz;
  }
}

// Solution 3:
public class Kata
{
  public static int[] PreFizz(int n) 
  {
  var arr = new int[n];
    for (int i = 0; i < n; i++)
    arr[i] = i + 1;
      return arr;
  }
}

// Sample Tests Passed:
// namespace Solution 
// {
//   using NUnit.Framework;
//   using System;  

//   [TestFixture]
//   public class KataTests
//   {
//     [Test]
//     public void BasicTests()
//     {
//       Assert.AreEqual(new int[] { 1 }, Kata.PreFizz(1), "Array should be from 1 to 1");
//       Assert.AreEqual(new int[] { 1, 2 }, Kata.PreFizz(2), "Array should be from 1 to 2");
//       Assert.AreEqual(new int[] { 1, 2, 3 }, Kata.PreFizz(3), "Array should be from 1 to 3");
//       Assert.AreEqual(new int[] { 1, 2, 3, 4 }, Kata.PreFizz(4), "Array should be from 1 to 4");
//       Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, Kata.PreFizz(5), "Array should be from 1 to 5");      
//     }
//   }
// }