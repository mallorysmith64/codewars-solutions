// Language: Javascript
// Level: 8kyu
// Name of Problem: Switch it Up!

// Instructions: When provided with a number between 0-9, return it in words.
// Input :: 1 Output :: "One"
// If your language supports it, try using a switch statement.

// Solution:
const switchItUp = number => {
  switch (number) {
    case 0:
      return "Zero";
    case 1:
      return "One";
    case 2:
      return "Two";
    case 3:
      return "Three";
    case 4:
      return "Four";
    case 5:
      return "Five";
    case 6:
      return "Six";
    case 7:
      return "Seven";
    case 8:
      return "Eight";
    case 9:
      return "Nine";
  }
};

// Sample Tests Passed:
// Test.assertEquals(switchItUp(1),"One");
// Test.assertEquals(switchItUp(3),"Three");
// Test.assertEquals(switchItUp(5),"Five");