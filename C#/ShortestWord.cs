// Language: C#
// Level: 7kyu
// Name of Problem: Shortest Word

// Instructions: Simple, given a string of words, return the length of the shortest word(s).
// String will never be empty and you do not need to account for different data types.

using System.Linq;

// Solution 1:
public class Kata
{
  public static int FindShort(string s)
  {
    var arr = s.Split(' ');
    var shortest = arr[0];
      for (var i = 0; i < arr.Length; i++) {
      if (arr[i].Length < shortest.Length) {
    shortest = arr[i];
    }
}
    return shortest.Length;
    }
}

// Solution 2:
//don't forget to uncomment "using System.Linq;" for solution to work properly

// using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(' ').Min(x => x.Length);
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
//       Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
//       Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));      
//     }
//   }
// }