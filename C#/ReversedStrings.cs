// Level: 8kyu
// Name: Reversed Strings
// Instructions: Complete the solution so that it reverses the string value passed into it.
// Kata.Solution("world") //returns "dlrow"

//Solution 1 in C#
using System;

public static class Kata
{
  public static string Solution(string str)
  {
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
    }
  }

//Solution 2:
// using System;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     char[] chars = str.ToCharArray();  
//     for (int i = 0, j = str.Length - 1; i < j; i++, j--) {  
//         chars[i] = str[j];  
//         chars[j] = str[i];  
//     }  
//     return new string(chars);  
//   } 
// }

// Sample Tests Passed:
// namespace Solution
// {
//   using NUnit.Framework;
  
//   [TestFixture]
//   public class Tests
//   {
//     [Test]
//     public void World()
//     {
//       Assert.AreEqual("dlrow", Kata.Solution("world"));
//     }
//   }
// }