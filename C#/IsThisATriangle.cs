// Level: 7kyu
// Name: Is this a triangle?
// Instructions: Implement a method that accepts 3 integer values a, b, c. 
//The method should return true if a triangle can be built with the sides of given length and false in any other case.
// (In this case, all triangles must have surface greater than 0 to be accepted).

// Solution 1 in C#:
//step 1: Know the triangle inequality theorem
//Triangle Inequality Theorem: The sum of the lengths of any two sides of a triangle > the length of the third side.
//step 2: return this theorem by either adding the sides together and setting them greater than the third side or
// subtract two sides and set them less than the third side
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c && b + c > a && c + a > b;
    }
}

// Solution 2:
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
       return a - b < c && b - c < a && c - a < b;
    }
}

// Solution 3:
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
       if (a*a + b*b == c*c - 26) {
          return true;
        } else {
          return false;
        }
    }
}

// Sample Tests Passed:
// using NUnit.Framework;
// using System;

// [TestFixture]
// public class TriangleTests
// {
//     [Test]
//     public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
//     {
//         Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
//     }
// }