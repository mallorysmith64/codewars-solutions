// Language: Javascript
// Level: 8kyu
// Name of Problem: The 'if' function

// Instructions: Who likes keywords? Nobody likes keywords, so why use them?
// You know what keyword I use too much? if! We should make a function called _if, 
// with its arguments as a logical test and two functions/lambdas where the first function is executed if the boolean is true, 
// and the second if it's false, like an if/else statement,
// Even so, It should support truthy/falsy types just like the keyword. 

// Examples:
// Logs 'True' to the console.
_if(true, function(){console.log("True")}, function(){console.log("false")})

// Solution 1:
function _if(bool, func1, func2) {
    bool ? func1() : func2()
  }

// Solution 2:
function _if(bool, f1, f2) {
    if (bool)
      f1();
    else
      f2();
 }

// Sample Tests Passed:
// no test cases given