// Level: 8kyu
// Name: MakeUpperCase
// Instructions: Write function makeUpperCase

// Solution in C#

//todo write solution here

// Sample Tests Passed:
namespace Learning {
  using NUnit.Framework;
  using System;
  [TestFixture]
  public class MakeUpperCaseTest
  {
    [Test]
    public void BasicTest()
    {
       Assert.AreEqual("HELLO", Kata.MakeUpperCase("hello"));    
    }
  }    
}
