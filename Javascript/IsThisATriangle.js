// Level: 7kyu
// Name: Is this a triangle?
// Instructions: Implement a method that accepts 3 integer values a, b, c. 
// The method should return true if a triangle can be built with the sides of given length and false in any other case.
// (In this case, all triangles must have surface greater than 0 to be accepted).

// Solution in Javascript
function hoopCount (n) {
    if (n >= 10) {
    return "Great, now move on to tricks";
    } else {
    return "Keep at it until you get it";
     }
  }

// Sample Tests Passed:
// Test.describe("PublicTest", function() {
//     Test.assertEquals(isTriangle(1,2,2), true);
//     Test.assertEquals(isTriangle(7,2,2), false);
// });