// Language: C#
// Level: 8kyu
// Name of Problem: MakeUpperCase

// Instructions: Write function makeUpperCase

// Solution:
//step 1: know String.ToUpper Method
//resource: https://docs.microsoft.com/en-sg/dotnet/api/system.string.toupper?view=netframework-4.8

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