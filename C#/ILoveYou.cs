// Language: C#
// Level: 8kyu
// Name of Problem: I love you, a little , a lot, passionately ... not at all

// Instructions: Who remembers back to their time in the schoolyard, when girls would take a flower and tear its petals, saying each of the following phrases each time a petal was torn:
// I love you, a little, a lot, passionately, madly, not at all

// Your goal in this kata is to determine which phrase the girls would say for a flower of a given number of petals, where nb_petals > 0.

// Solution:
using System;

public class Kata
{
  public static string HowMuchILoveYou(int petals)
  {
  int answer = petals % 6;
  switch (answer)
  {
    case 1: 
    return ("I love you");
    break;
    case 2:
    return ("a little");
    break;
    case 3:
    return ("a lot");
    break;
    case 4:
    return ("passionately");
    break;
    case 5:
    return ("madly");
    break;
    default:
    return ("not at all");
    break;
    }
  }
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class Test
//   {
//     [Test]
//     public void SampleTests()
//     {
//       Assert.AreEqual("I love you", Kata.HowMuchILoveYou(7));
//       Assert.AreEqual("a lot", Kata.HowMuchILoveYou(3));
//       Assert.AreEqual("not at all", Kata.HowMuchILoveYou(6));
//     }
//   }
// }