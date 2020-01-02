// Language: C#
// Level: 8kyu
// Name of Problem: Well of Ideas - Easy Version

// Instructions: For every good kata idea there seem to be quite a few bad ones! 
// In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'. 
// If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'. 
// If there are no good ideas, as is often the case, return 'Fail!'.

// Solution:
//Tip: make sure to use double quotes or you will get the error "too many characters in character literal"
//step 1: count how many times "good" appears, store this in count
//step 2: take variable and if > 2 return "I smell a series"
//step 3: or if variable >= 1 return "Publish!"
//step 4: else return "Fail"
using System.Linq;

public class Kata
{
  public static string Well(string[] x)
  {
  int count = x.Count(g => g == "good");
  return count > 2 ? "I smell a series!" : count >= 1 ? "Publish!" : "Fail!";
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
//       Assert.AreEqual("Fail!", Kata.Well(new string[] {"bad", "bad", "bad"}));
//       Assert.AreEqual("Publish!", Kata.Well(new string[] {"good", "bad", "bad", "bad", "bad"}));
//       Assert.AreEqual("I smell a series!", Kata.Well(new string[] {"good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good"}));
//     }
//   }
// }