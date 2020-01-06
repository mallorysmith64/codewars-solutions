// Language: Javascript
// Level: 7kyu
// Name of Problem: Sum of Triangular Numbers

// Instructions: Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.
// Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."

// Examples:
// [01]
// 02 [03]
// 04 05 [06]
// 07 08 09 [10]
// 11 12 13 14 [15]
// 16 17 18 19 20 [21]
// e.g. If 4 is given: 1 + 3 + 6 + 10 = 20.

// Solution 1: add triangular numbers one by one
//step1: set the initial sum to 0
//step2: for loop start at 1, do not go over n when summing, and increment
//step3: find sum of series
//resource: https://www.geeksforgeeks.org/sum-series-1-3-6-10-triangular-numbers/

function sumTriangularNumbers(n) {
    let sum = 0
    for (let i = 1; i <= n; i++) {
     sum += i * (i + 1) / 2
    }
     return sum;
  }

// Solution 2:
// todo: write this solution more efficiently here

// Sample Tests Passed:
// Test.assertEquals(sumTriangularNumbers(6), 56);
// Test.assertEquals(sumTriangularNumbers(34), 7140);
// Test.assertEquals(sumTriangularNumbers(-291), 0);
// Test.assertEquals(sumTriangularNumbers(943), 140205240);
// Test.assertEquals(sumTriangularNumbers(-971), 0);