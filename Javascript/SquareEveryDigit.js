// Language: Javascript
// Level: 7kyu
// Name of Problem: Square Every Digit

// Instructions: You are asked to square every digit of a number.
// The function accepts an integer and returns an integer

// Example:
// If we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

// Solution 1:
function squareDigits(num){
    return Number((num + '').split("").map(c => c * c).join(""));
  }

// Solution 2:
const squareDigits = (num) => Number((num + '').split("").map(c => c *c).join(""));

// Solution 3:
function squareDigits(num){
    var i, sqr=[],n;
       num = num.toString();
       for(i = 0; i < num.length; i++){
           n = Number(num[i]);
       sqr.push(n*n);
     }
       return Number(sqr.join(""))
    }

// Sample Tests Passed:
// Test.assertEquals(squareDigits(9119), 811181);