// Language: Javascript
// Level: 8kyu
// Name of Problem: L1 - Set Alarm

// Instructions: Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
// The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. 

// Examples: 
// setAlarm(true, true) -> false 
// setAlarm(false, true) -> false 
// setAlarm(false, false) -> false 
// setAlarm(true, false) -> true

// Solution:
//step1: problem says to write function called setAlarm, so write function setAlarm
//step2: function takes two parameters called employed and vacation, so now you have function setAlarm(employed, vacation)
//step3: return true if employed AND also not on vacation else return false

function setAlarm(employed, vacation){
    return employed && !vacation
  }
  
// Sample Tests Passed:
// Test.expect(!setAlarm(true, true), "Should be false.");
// Test.expect(!setAlarm(false, true), "Should be false.");
// Test.expect(setAlarm(true, false), "Should be true.");