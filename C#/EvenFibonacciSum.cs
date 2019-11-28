// Level: 6kyu
// Name: Even Fibonacci Sum
// Instructions: Give the summation of all even numbers in a Fibonacci sequence up to, but not including, the maximum value.
// The Fibonacci sequence is a series of numbers where the next value is the addition of the previous two values. The series starts with 0 and 1:
// 0 1 1 2 3 5 8 13 21...

// For example:
// Kata.Fibonacci(0) // returns 0
// Kata.Fibonacci(33) // returns 10
// Kata.Fibonacci(25997544) // returns 19544084

// Solution 1 in C#:
public static class Kata
{
  public static long Fibonacci(int n)
  {
      if ((n == 0) || (n == 1))
      {
    return 0;
      }
    long ef1 = 0, ef2 = 2;
    long sum = ef1 + ef2;
    while (ef2 <= n)
    {
    long ef3 = 4 * ef2 + ef1;
    if (ef3 > n)
    break;
    ef1 = ef2; 
    ef2 = ef3; 
    sum += ef2; 
    } 
    return(int) sum; 
  } 
}

// Solution 2:
public static class Kata
{
    public static long Fibonacci(int max)
    {
      long ef = 1;
      long ef2 = 2;
      long evens = 0;
      long sum = 0;
      while (ef2 < max){
        sum = ef + ef2;
        ef = ef2;
        if (ef % 2 == 0) evens+= ef;
        ef2 = sum;
      }
      return evens;
    }
}

// Sample Tests Passed:
// using NUnit.Framework;

// [TestFixture]
// public class Tests
// {
//   [Test]
//   public void Test1()
//   {
//     Assert.AreEqual(10, Kata.Fibonacci(10));
//   }
// }