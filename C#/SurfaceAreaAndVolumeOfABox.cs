// Language: C#
// Level: 8kyu
// Name of Problem: Surface Area and Volume of a Box

// Instructions: Write a function that returns the total surface area and volume of a box as an array: [area, volume]

// Solution:
//step 1: calculate area
//step 2: calculate volume
//step 3: return new array of integers like this: return new int[] {area, volume};
//Tip: do NOT return answer like this: return [area, volume] b/c this syntax will NOT work in C#!!!
using System;

    public class Kata
    {
        public static int[] Get_size(int width,int height,int depth)
        {
      int area = (width * depth + depth * height + width * height) * 2;
      int volume = width * height * depth;
      return new int[] {area, volume};
        }
    }

// Sample Tests Passed:
// using System;
// using NUnit.Framework;

//     [TestFixture]
//     public class Test
//     {
//         [Test]
//         public void Test1()
//         {
//             Assert.AreEqual(new[] { 88, 48 }, Kata.Get_size(4, 2, 6));
//             Assert.AreEqual(new[] { 6, 1 }, Kata.Get_size(1, 1, 1));
//             Assert.AreEqual(new[] { 10, 2 }, Kata.Get_size(1, 2, 1));
//             Assert.AreEqual(new[] { 16, 4 }, Kata.Get_size(1, 2, 2));
//             Assert.AreEqual(new[] { 600, 1000 }, Kata.Get_size(10, 10, 10));
//         }
//     }