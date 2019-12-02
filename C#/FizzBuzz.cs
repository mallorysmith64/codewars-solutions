// Level: 7kyu
// Name: Fizz Buzz
// Instructions: Return an array containing the numbers from 1 to N, where N is the parametered value. N will never be less than 1 (in C#, N might be less then 1).
// C# ONLY: If N is smaller then or equal to 0, throw an ArgumentOutOfRangeException! 
// Replace certain values however if any of the following conditions are met:

// If the value is a multiple of 3: use the value 'Fizz' instead
// If the value is a multiple of 5: use the value 'Buzz' instead
// If the value is a multiple of 3 & 5: use the value 'FizzBuzz' instead

// Solution in C#

using System;
using System.Linq;

public class FizzBuzz {
  public static string[] GetFizzBuzzArray(int n) {
    if (n <= 0) throw new ArgumentOutOfRangeException();
    return Enumerable.Range(1, n).Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3  == 0 ? "Fizz" : x % 5  == 0 ? "Buzz" : x.ToString()).ToArray();
  }
}

// Sample Tests Passed:
// using System;
// using NUnit.Framework;

// [TestFixture]
// public class FizzBuzzTests
// {
// 	[Test]
// 	public void FizzBuzzTest_0()
// 	{
// 		int input = 0;
// 		Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzz.GetFizzBuzzArray(input));
// 	}

// 	[Test]
// 	public void FizzBuzzTest_1()
// 	{
// 		int input = 1;
// 		string[] expected = { "1" };

// 		string[] actual = FizzBuzz.GetFizzBuzzArray(input);

// 		Assert.AreEqual(expected, actual);
// 	}

// 	[Test]
// 	public void FizzBuzzTest_3()
// 	{
// 		int input = 3;
// 		string[] expected = { "1", "2", "Fizz" };

// 		string[] actual = FizzBuzz.GetFizzBuzzArray(input);

// 		Assert.AreEqual(expected, actual);
// 	}

// 	[Test]
// 	public void FizzBuzzTest_5()
// 	{
// 		int input = 5;
// 		string[] expected = { "1", "2", "Fizz", "4", "Buzz" };

// 		string[] actual = FizzBuzz.GetFizzBuzzArray(input);

// 		Assert.AreEqual(expected, actual);
// 	}

// 	[Test]
// 	public void FizzBuzzTest_15()
// 	{
// 		int input = 15;
// 		string[] expected = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

// 		string[] actual = FizzBuzz.GetFizzBuzzArray(input);

// 		Assert.AreEqual(expected, actual);
// 	}
// }