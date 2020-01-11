// Language: Javascript
// Level: 8kyu
// Name of Problem: Pre-FizzBuzz Workout #1

// Instructions: This is the first step to understanding FizzBuzz.
// Your job is to write an algorithm that gets you from the input to the output.

// Examples:
// Your inputs: a positive integer, n, greater than or equal to one. n is provided, you have NO CONTROL over its value.
// Your expected output is an array of positive integers from 1 to n (inclusive).

// Solution 1:
function preFizz(n) {
    let arr = []
    for (let i = 1; i <= n ; i++)
    arr.push(i)
        return arr
    }

// Sample Tests Passed:
// Test.describe('Fixed Tests', _ => {
//     Test.it("Test", __ => {
//       Test.assertSimilar(preFizz(1), [1], `Array should be from 1 to 1`);
//       Test.assertSimilar(preFizz(2), [1,2], `Array should be from 1 to 2`);
//       Test.assertSimilar(preFizz(3), [1,2,3], `Array should be from 1 to 3`);
//       Test.assertSimilar(preFizz(4), [1,2,3,4], `Array should be from 1 to 4`);
//       Test.assertSimilar(preFizz(5), [1,2,3,4,5], `Array should be from 1 to 5`);
//     });
//   });