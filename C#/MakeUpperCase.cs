// Level: 8kyu
// Name: MakeUpperCase
// Instructions: Write function makeUpperCase

// Solution in C#
public class Kata
  {
        public static string MakeUpperCase(string str)
        {
             return str.ToUpper();
        }

  }


// Sample Tests Passed:
// namespace Learning {
//   using NUnit.Framework;
//   using System;
//   [TestFixture]
//   public class MakeUpperCaseTest
//   {
//     [Test]
//     public void BasicTest()
//     {
//        Assert.AreEqual("HELLO", Kata.MakeUpperCase("hello"));    
//     }
//   }    
// }