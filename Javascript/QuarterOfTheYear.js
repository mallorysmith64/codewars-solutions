// Language: Javascript
// Level: 8kyu
// Name of Problem: Quarter of the Year

/*Instructions:
Given a month as an integer from 1 to 12, 
return to which quarter of the year it belongs as an integer number.
For example: month 2 (February), is part of the first quarter; month 6 (June), 
is part of the second quarter; and month 11 (November), is part of the fourth quarter.
*/

// Solution:
const quarterOf = (month) => {
  if (month <= 3) { // jan, feb, march
    return 1;
  } else if (month <= 6) { // april, may, june
    return 2;
  } else if (month <= 9) { // july, aug, sept
    return 3;
  } else if (month <= 12) { // oct, nov, dec
    return 4;
  }
};

// Sample Tests Passed
// const chai = require("chai");
// const assert = chai.assert;
// chai.config.truncateThreshold=0;

// describe("Basic Tests", () =>{
//   it("Testing for fixed tests", () => {
//     assert.strictEqual(quarterOf(3), 1)
//     assert.strictEqual(quarterOf(8), 3)
//     assert.strictEqual(quarterOf(11), 4)
//   });
// });
