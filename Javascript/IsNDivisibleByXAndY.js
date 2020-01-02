// Language: Javascript
// Level: 8kyu
// Name of Problem: Is n divisible by x and y?

// Instructions: Create a function isDivisible(n, x, y) that checks if a number n is divisible by two numbers x AND y. 
// All inputs are positive, non-zero digits.

// Examples:
// is_divisible(3,1,3)--> True because 3 is divisible by 1 and 3
// is_divisible(12,2,6)--> True because 12 is divisible by 2 and 6
// is_divisible(100,5,3)--> False because 100 is not divisible by 3
// is_divisible(12,7,5)--> False because 12 is neither divisible by 7 nor 5

// Solution 1 using if/else statement:
const isDivisible = (n, x, y) => {
    if (n % x === 0 && n % y === 0) {
    return true
    } else {
    return false 
      }
    }

// Solution 2 using ternary operator:
//tip: remember ternary operator pattern is return condition ? value if true : value if false

const isDivisible = (n, x, y) => {
    return (n % x === 0 && n % y === 0) ? true : false
  }

// Sample Tests Passed:
// Test.assertSimilar(isDivisible(3,3,4),false);
// Test.assertSimilar(isDivisible(12,3,4),true);
// Test.assertSimilar(isDivisible(8,3,4),false);
// Test.assertSimilar(isDivisible(48,3,4),true);