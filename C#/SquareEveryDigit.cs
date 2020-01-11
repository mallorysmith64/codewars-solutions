// Language: C#
// Level: 7kyu
// Name of Problem: Square Every Digit

// Instructions: You are asked to square every digit of a number.
// Note: The function accepts an integer and returns an integer

// Examples: 
// If we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

// Solution 1:
using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string SquaredNums = "";
    foreach (char c in n.ToString())
    {
      int square = int.Parse(c.ToString());
      SquaredNums += (square * square);
    }
    return int.Parse(SquaredNums);
  }
}

// Solution 2:
//don't forget to uncomment "using System;" and "using System.Linq;"

// using System;
// using System.Linq;
public class Kata
{
  public static int SquareDigits(int n)
  {
  int result = 0;
  int places = 0;
  
    while(n > 0) {
        int digit = n % 10;
        int square = digit * digit; 

        result += (int)Math.Pow(10,places) * square;    
        places += square > 10 ? 2 : 1;  
        n /= 10;
    }
    return result;
  }
}

// Sample Tests Passed:
// using System;
// using NUnit.Framework;

// [TestFixture]
// public class KataTest
// {
//   [Test]
//   public void SquareDigitsTest()
//   {
//     Assert.AreEqual(811181, Kata.SquareDigits(9119));
//   }
// }