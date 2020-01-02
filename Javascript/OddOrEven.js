// Language: Javascript
// Level: 7kyu
// Name of Problem: Odd or Even?

// Instructions: Given an array of numbers (a list in groovy), determine whether the sum of all of the numbers is odd or even.
// Give your answer in string format as 'odd' or 'even'.
// If the input array is empty consider it as: [0] (array with a zero).

// Examples:
// oddOrEven([0]) returns "even"
// oddOrEven([2, 5, 34, 6]) returns "odd"
// oddOrEven([0, -1, -5]) returns "even"

// Solution:
function oddOrEven(array) {
  return array.reduce((total, value) => total + value, 0) % 2 === 0
    ? "even"
    : "odd";
}

// Sample Tests Passed:
// Test.describe('Fixed tests', _ => {
//   Test.it('Edge tests', _ => {
//     Test.assertEquals(oddOrEven([0]), 'even')
//     Test.assertEquals(oddOrEven([1]), 'odd')
//     Test.assertEquals(oddOrEven([]), 'even')
//   });

//   Test.it('Even tests', _ => {
//     Test.assertEquals(oddOrEven([0, 1, 5]), 'even')
//     Test.assertEquals(oddOrEven([0, 1, 3]), 'even')
//     Test.assertEquals(oddOrEven([1023, 1, 2]), 'even')
//   });

//   Test.it('Negative Even tests', _ => {
//     Test.assertEquals(oddOrEven([0, -1, -5]), 'even')
//     Test.assertEquals(oddOrEven([0, -1, -3]), 'even')
//     Test.assertEquals(oddOrEven([-1023, 1, -2]), 'even')
//   });

//   Test.it('Odd tests', _ => {
//     Test.assertEquals(oddOrEven([0, 1, 2]), 'odd')
//     Test.assertEquals(oddOrEven([0, 1, 4]), 'odd')
//     Test.assertEquals(oddOrEven([1023, 1, 3]), 'odd')
//   });

//   Test.it('Negative Odd tests', _ => {
//     Test.assertEquals(oddOrEven([0, -1, 2]), 'odd')
//     Test.assertEquals(oddOrEven([0, 1, -4]), 'odd')
//     Test.assertEquals(oddOrEven([-1023, -1, 3]), 'odd')
//   });
// });