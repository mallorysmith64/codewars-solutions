// Language: C#
// Level: 8kyu
// Name of Problem: L1 - Set Alarm

// Instructions: Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
// The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. 

// Examples: setAlarm(true, true) -> false setAlarm(false, true) -> false setAlarm(false, false) -> false setAlarm(true, false) -> true
// setalarm(true, true) -> false
// setalarm(false, true) -> false
// setalarm(false, false) -> false
// setalarm(true, false) -> true

// Solution:
//step1: within a namespace write a function named SetAlarm 
//Ex: public static setAlarm

//step2: setAlarm has two parameters called employed and vacation make sure they are boolean values
//Ex: public static bool setAlarm(bool employed, bool vacation)

//step3: return true if employed AND also not on vacation else return false, don't forget your semicolon
//Ex: return employed && !vacation;

public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    return employed && !vacation;
  }
}
  
// Sample Tests Passed:
// namespace Solution {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class SetAlarmTest {
//     [Test]
//     public void Tests() {
//       Assert.AreEqual(false, Kata.SetAlarm(true, true));
//       Assert.AreEqual(false, Kata.SetAlarm(false, true));
//       Assert.AreEqual(true, Kata.SetAlarm(true, false));
//       Assert.AreEqual(false, Kata.SetAlarm(false, false));
//     }
//   }
// }