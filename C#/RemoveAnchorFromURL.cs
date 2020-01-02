// Language: C#
// Level: 7kyu
// Name of Problem: Remove anchor from URL

// Instructions: Complete the function/method so that it returns the url with anything after the anchor (#) removed.

// Examples:
// Kata.RemoveUrlAnchor("www.codewars.com#about") => "www.codewars.com"
// Kata.RemoveUrlAnchor("www.codewars.com?page=1") => "www.codewars.com?page=1"

// Solution:
public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    return url.Split("#")[0];
  }
}

// Sample Tests Passed:
// namespace Solution 
// {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class Tests
//   {
//     [Test, Description("Sample Tests")]
//     public void SampleTests()
//     {
//       Assert.AreEqual("www.codewars.com", Kata.RemoveUrlAnchor("www.codewars.com#about"));
//       Assert.AreEqual("www.codewars.com/katas/?page=1", Kata.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
//       Assert.AreEqual("www.codewars.com/katas/", Kata.RemoveUrlAnchor("www.codewars.com/katas/"));
//     }
//   }
// }