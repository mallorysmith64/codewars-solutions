// Language: C#
// Level: 8kyu
// Name of Problem: The 'if' function

// Instructions: Who likes keywords? Nobody likes keywords, so why use them?
// You know what keyword I use too much? if!
// We should make a function called _if, with its arguments as a logical test
// and two functions/lambdas where the first function is executed if the boolean is true, 
// and the second if it's false, like an if/else statement
// Even so, It should support truthy/falsy types just like the keyword.

// Example: 
// write "True" to console
// Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));

// Solution 1:
//don't forget to uncomment "using System;" from these solutions!

// using System;
public class Kata
{
  public static void If(bool condition, Action func1, Action func2)
  {
     (condition ? func1 : func2)();
  }
}

// Solution 2:
// using System;
public class Kata
{
  public static void If(bool condition, Action f1, Action f2)
  {
    if (condition)
      f1();
    else
      f2();
  }
}

// Sample Tests Passed:
// using System;
// using NUnit.Framework;

// [TestFixture]
// public class Tests
// { 
//   [Test]
//   public void BasicTest()
//   {    
//     var a = false;
    
//     Kata.If(true, () => a = true, () => a = false);
      
//     Assert.True(a, "func1 should be called");
//   }
// }