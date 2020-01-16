// Language: Javascript
// Level: 7kyu
// Name of Problem: Fizz / Buzz

// Instructions: Write a function that takes an integer and returns an array [A, B, C]
// A is the number of multiples of 3 (but not 5) below the given integer, 
// B is the number of multiples of 5 (but not 3) below the given integer,
// C is the number of multiples of 3 and 5 below the given integer

// Example:
// solution(20) should return [5, 2, 1]

// Solution 1:
function solution(n){
    let arr = [0, 0, 0]
    for (let i = 1; i < n; i++) {
    if (i % 3 === 0 && i % 5 === 0) arr[2] +=1;
        else if(i % 3 !== 0 && i % 5 === 0) arr[1] +=1;
        else if(i % 3 === 0 && i % 5 !== 0) arr[0] +=1;
      }
    return arr;
    }

// Sample Tests Passed:
// Test.assertDeepEquals(solution(20), [5, 2, 1]);
// Test.assertDeepEquals(solution(2), [0, 0, 0]);
// Test.assertDeepEquals(solution(14), [4,2,0]);
// Test.assertDeepEquals(solution(30), [8, 4, 1]);
// Test.assertDeepEquals(solution(141), [37, 19, 9]);