// Level: 8kyu
// Name: Surface Area and Volume of a Box
// Instructions: Write a function that returns the total surface area and volume of a box as an array: [area, volume]

//Solution in C#
//this solution is a work in progress!!!!!!
//this will NOT work!!!
using System;

    public class Kata
    {
        public static int[] Get_size(int width,int height,int depth)
        {
            double area = (width * depth + depth * height * height) * 2;
            double volume = width * height * depth;
            return area; volume;
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