// Language: Javascript
// Level: 8kyu
// Name of Problem: Sum of differences in array

// Instructions: Your task is to sum the differences between consecutive pairs in the array in descending order.
// If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell).

// Example:
// For example: sumOfDifferences([2, 1, 10]) Returns 9
// Descending order: [10, 2, 1]
// Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

// Solution 1:
function sumOfDifferences(arr) {
    return arr.length <= 1 ? 0 : Math.max(...arr) - Math.min(...arr)
    }

// Solution 2:
function sumOfDifferences(arr) {
    return arr.length > 1 ? Math.max(...arr) - Math.min(...arr) : 0
    }

// Sample Tests Passed:
// Test.describe("sumOfDifferences([1, 2, 10]", function() {
//     Test.assertEquals(sumOfDifferences([1, 2, 10]), 9);
//   });
  
//   Test.describe("sumOfDifferences([-3, -2, -1])", function() {
//     Test.assertEquals(sumOfDifferences([-3, -2, -1]), 2);
//   });