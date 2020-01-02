// Language: C#
// Level: 7kyu
// Name of Problem: Categorize New Member

// Instructions: The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help with an application form that will tell prospective members which category they will be placed.
// To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

// Input will consist of a list of lists containing two items each. Each list contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.
// Note for F#: The input will be of (int list list) which is a List<List>
// Example Input: [[18, 20],[45, 2],[61, 12],[37, 6],[21, 21],[78, 9]]

// Output will consist of a list of string values (in Haskell: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
// Example Output: ["Open", "Open", "Senior", "Open", "Open", "Senior"]

// Solution:
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static IEnumerable<string> OpenOrSenior(int[][] data) => data.Select(x => { return (x[0] >= 55 && x[1] > 7) ? "Senior" : "Open"; });
}

// Sample Tests Passed:
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using NUnit.Framework;

// namespace Solution
// {
//     [TestFixture]
//     public class KataOpenOrSeniorTests
//     {
//         [Test]
//         public void SampleTest()
//         {
//             Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
//             Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
//             Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
//         }

//     }
// }