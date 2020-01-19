// Language: C#
// Level: 8kyu
// Name of Problem: Alan Partridge II - Apple Turnover

// Instructions: As a treat, I'll let you read part of the script from a classic 'I'm Alan Partridge episode:

// Lynn: Alan, there’s that teacher chap.
// Alan: Michael, if he hits me, will you hit him first?
// Michael: No, he’s a customer. I cannot hit customers. I’ve been told. I’ll go and get some stock.
// Alan: Yeah, chicken stock.
// Phil: Hello Alan.
// Alan: Lynn, hand me an apple pie. And remove yourself from the theatre of conflict.
// Lynn: What do you mean?
// Alan: Go and stand by the yakults. The temperature inside this apple turnover is 1,000 degrees. If I squeeze it, a jet of molten Bramley apple is going to squirt out. Could go your way, could go mine. Either way, one of us is going down.
// Alan is known for referring to the temperature of the apple turnover as 'Hotter than the sun!'. According to space.com the temperature of the sun's corona is 2,000,000 degrees C, but we will ignore the science for now.

// Your job is simple, if (x) squared is more than 1000, return 'It's hotter than the sun!!', else, return 'Help yourself to a honeycomb Yorkie for the glovebox.'.
// X will be either a number or a string. Both are valid.

// Solution 1:
using System;
public class Kata
{
  public static string Apple(object n)
  {
    return Convert.ToDouble(n) * Convert.ToDouble(n) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
  }
}

// Solution 2:
//don't forget to uncomment "using System;" for this solution to work

// using System;
public class Kata
{
  public static string Apple(object n)
  {
    if (Math.Pow(Convert.ToInt32(n),2) > 1000) 
    return "It's hotter than the sun!!";
    return "Help yourself to a honeycomb Yorkie for the glovebox.";
  }
}

// Sample Tests Passed:
namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("It's hotter than the sun!!", Kata.Apple("50"));
      Assert.AreEqual("Help yourself to a honeycomb Yorkie for the glovebox.", Kata.Apple(4));
    }
  }
}
