// Language: C#
// Level: 7kyu
// Name of Problem: Numbers to Letters

// Instructions: Given an array of numbers, you must return a string. 
// The numbers correspond to the letters of the alphabet in reverse order: a = 26, z = 1 etc. 
// You should also account for '!', '?' and ' ' that are represented by '27', '28' and '29' respectively.

// Solution:
using System;
using System.Linq;

public class Kata
{
    public static string Switcher(string[] x)
  {
    return string.Join("", x.Select(alpha => "zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(alpha) - 1]).ToArray());  
  }
}

// Sample Tests Passed:
// namespace Solution
// {
//     using NUnit.Framework;
    
//     using System;
    
//     [TestFixture]
//     public class Tests
//     {
//         [Test]
//         public void ExampleTest1()
//         {
//             string expected = "codewars"; 
            
//             string actual = Kata.Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" });
        
//             Assert.AreEqual(expected, actual);
//         }
        
//         [Test]
//         public void ExampleTest2()
//         {
//             string expected = "btswmdsbd kkw"; 
            
//             string actual = Kata.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" });
        
//             Assert.AreEqual(expected, actual);
//         }
        
//         [Test]
//         public void ExampleTest3()
//         {
//             string expected = "wc"; 
            
//             string actual = Kata.Switcher(new string[] { "4", "24" });
        
//             Assert.AreEqual(expected, actual);
//         }
//     }
// }