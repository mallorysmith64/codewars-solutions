// Language: Javascript
// Level: 8kyu
// Name of Problem: String Repeat

// Instructions: Write a function called repeatString which repeats the given String src exactly count times.

// Examples:
repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"

// Solution 1 using if/else statement:
function repeatStr(n, string) {
    if (n > 0) {
       return string.repeat(n)
     } else {
       return ""
     }
   }

// Solution 2 using ternary operator:
function repeatStr (n, str) {
    return n > 0 ? str.repeat(n) : ""
  }

// Sample Tests Passed:
describe("Tests", function() {
    it ("Basic tests", function() {
      Test.assertSimilar(repeatStr(3, "*"), "***");
      Test.assertSimilar(repeatStr(5, "#"), "#####");
      Test.assertSimilar(repeatStr(2, "ha "), "ha ha ");
    });
  });