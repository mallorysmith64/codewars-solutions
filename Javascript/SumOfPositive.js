// Level: 8kyu
// Name: Sum of positive
// Instructions: You get an array of numbers, return the sum of all of the positives ones.
// Example [1,-4,7,12] => 1 + 7 + 12 = 20
// Note: if there is nothing to sum, the sum is default to 0.

// Solution in Javascript
function positiveSum(arr) {
  return !arr.length ? 0 : arr.reduce((res, x) => (x > 0 ? res + x : res), 0);
}

// Sample Tests Passed:
// Test.assertEquals(positiveSum([1,2,3,4,5]),15);
// Test.assertEquals(positiveSum([1,-2,3,4,5]),13);
// Test.assertEquals(positiveSum([]),0);
// Test.assertEquals(positiveSum([-1,-2,-3,-4,-5]),0);
// Test.assertEquals(positiveSum([-1,2,3,4,-5]),9);