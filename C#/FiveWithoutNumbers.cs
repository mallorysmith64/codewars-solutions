// Level: 8kyu
// Name: 5 Without NUmbers
// Instructions: Write a function that always returns 5
// Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/

//Solution 1 in C#:
class Kata
{
    public static int UnusualFive()
    {
     return "today".Length;
    }
}

//Solution 2 in C#:
class Kata
{
    public static int UnusualFive()
    {
     return ".....".Length;
    }
}

// Sample Tests Passed:
// using NUnit.Framework;
// [TestFixture]
// class Tests
// {
//     [Test]
//     public void Test()
//     {
//         Assert.That(Kata.UnusualFive(), Is.EqualTo(5));
//     }
// }