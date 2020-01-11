// Language: C#
// Level: 7kyu
// Name of Problem: Alphabetical Addition

// Instructions: The function will be given an array of letters (chars), each one being a letter to add. 
// Return a char
// Letters will always be lowercase
// Letters can overflow (see second to last example of the description)
// If no letters are given, the function should return 'z'

// Examples: 
// AddLetters(new char[] {'a', 'b', 'c'}) = 'f'
// AddLetters(new char[] {'a', 'b'}) = 'c'
// AddLetters(new char[] {'z'}) = 'z'
// AddLetters(new char[] {'z', 'a'}) = 'a'
// AddLetters(new char[] {'y', 'c', 'b'}) = 'd' // notice the letters overflowing
// AddLetters(new char[] {}) = 'z'

// Solution 1:
//don't forget to uncomment "using System.Linq;" for solution to work

using System;
// using System.Linq;
public class Kata {
  public static char AddLetters(char[] letters) {
  int sum = (letters.Sum(x => x - 96) % 26);
    return sum == 0 ? 'z' : (char)(sum + 96);
  }
}

// Solution 2:
//don't forget to uncomment "using System.Linq;" for solution to work

// using System.Linq;
public class Kata {
public static char AddLetters(char[] letters, string alphabet ="zabcdefghijklmnopqrstuvwxy") => 
  alphabet[letters.Sum(x => alphabet.IndexOf(x)) % 26];
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;
  
//   [TestFixture]
//   public class SolutionTest {    
//     [Test]
//     public void BasicTests() {
//       Assert.AreEqual('f', Kata.AddLetters(new char[] {'a', 'b', 'c'}));
//       Assert.AreEqual('z', Kata.AddLetters(new char[] {'z'}));
//       Assert.AreEqual('c', Kata.AddLetters(new char[] {'a', 'b'}));
//       Assert.AreEqual('c', Kata.AddLetters(new char[] {'c'}));
//       Assert.AreEqual('a', Kata.AddLetters(new char[] {'z', 'a'}));
//       Assert.AreEqual('d', Kata.AddLetters(new char[] {'y', 'c', 'b'}));
//       Assert.AreEqual('z', Kata.AddLetters(new char[] {}));
//     }
//   }
// }