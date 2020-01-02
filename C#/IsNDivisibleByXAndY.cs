// Language: C#
// Level: 8kyu
// Name of Problem: Is n divisible by x and y?

// Instructions: Create a function isDivisible(n, x, y) that checks if a number n is divisible by two numbers x AND y. 
// All inputs are positive, non-zero digits.

// Examples:
// isDivisible(3,1,3)--> true because 3 is divisible by 1 and 3
// isDivisible(12,2,6)--> true because 12 is divisible by 2 and 6
// isDivisible(100,5,3)--> false because 100 is not divisible by 3
// isDivisible(12,7,5)--> false because 12 is neither divisible by 7 nor 5

// Solution 1 using if/else statement:
  public class DivisibleNb {
	public static bool isDivisible(long n, long x, long y) {
    if (n % x == 0 && n % y == 0) {
    return true;
    } else {
    return false;
	  }
  }
}

// Solution 2 using ternary operator:
public class DivisibleNb {
	public static bool isDivisible(long n, long x, long y) {
    return (n % x == 0 && n % y == 0) ? true : false;
  }
}

// Sample Tests Passed:
// using System;
// using NUnit.Framework;

// [TestFixture]
// public class DivisibleNbTests {

// [Test]
//   public void Test1() {
//     Assert.AreEqual(true, DivisibleNb.isDivisible(12,4,3));
//   }
// [Test]
//   public void Test2() {
//     Assert.AreEqual(false, DivisibleNb.isDivisible(3,3,4));
//   }
// [Test]  public void Test3() {
//     Assert.AreEqual(false, DivisibleNb.isDivisible(8,3,4));
//   }
    
// }