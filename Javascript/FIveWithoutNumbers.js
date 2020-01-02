// Language: Javascript
// Level: 8kyu
// Name of Problem: 5 Without Numbers

// Instructions: Write a function that always returns 5
// Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/

// Solution 1:
function unusualFive() {
    return ".....".length
  }

// Solution 2:
function unusualFive(a, b, c, d, e) {
    return unusualFive.length
  }

// Solution 3:
function unusualFive() {
    return "today".length
  }

// Sample Tests Passed:
// describe("unusualFive", function(){
//   it("should return 5", function(){
//     assert.strictEqual(unusualFive(), 5);
//   });
// });