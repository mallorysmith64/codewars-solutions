// Language: C#
// Level: 8kyu
// Name of Problem: Calculate BMI

// Instructions: Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
// if bmi <= 18.5 return "Underweight"
// if bmi <= 25.0 return "Normal"
// if bmi <= 30.0 return "Overweight"
// if bmi > 30 return "Obese"

//don't forget to uncomment "using System;" from these solutions when necessary!

// Solution 1 using ternary operator:
// using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
  var bmi = weight/Math.Pow(height,2);
  return bmi <= 18.5 ? "Underweight" :
         bmi <= 25.0 ? "Normal" :
         bmi <= 30.0 ? "Overweight" : "Obese";
  }
}

// Solution 2 using if statements:
public class Kata
{
  public static string Bmi(double weight, double height)
  {
  var bmi = weight/(height*height);
    if (bmi <= 18.5)
      return "Underweight";
    if (bmi <= 25)
      return "Normal";
    if (bmi <= 30)
      return "Overweight";
      return "Obese";
  }
}

// Solution 3 using if/else statements:
// using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    var bmi = weight/Math.Pow(height,2);
    if (bmi <= 18.5) {
    return "Underweight";
  } else if (bmi <= 25) {
    return "Normal";
  } else if (bmi <= 30) {
    return "Overweight";
  } else {
    return "Obese";
    }
  }
}

// Solution 4 using switch statement:
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    var bmi = weight / (height*height);
    switch (bmi) {
      case double i when bmi <= 18.5:
        return "Underweight";
      case double i when bmi <= 25.0:
        return "Normal";
      case double i when bmi <= 30.0:
        return "Overweight";
      default:
        return "Obese";
    }
  }
}

// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class SolutionTest
//   {
//     [Test]
//     public void SampleTest()
//     {
//       Assert.AreEqual("Normal", Kata.Bmi(80, 1.80));
//     }
//   }
// }