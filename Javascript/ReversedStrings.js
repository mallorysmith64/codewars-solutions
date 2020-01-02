// Language: Javascript
// Level: 8kyu
// Name of Problem: Reversed Strings

// Instructions: Complete the solution so that it reverses the string value passed into it.

// Example:
// solution('world'); // returns 'dlrow'

// Solution 1:
//step1: split string
//step2: reverse
//step3: join string

function solution(str){
    return str.split('').reverse().join('')
  }

// Solution 2:
//step1: split string
//step2: reverse split string
//step3: join reversed string
//step4: return reversed joined string

const solution = (str) => {
    let splitString = str.split("")
    let reverseString = splitString.reverse()
    let joinedString = reverseString.join("")
    return joinedString
  }

// Sample Tests Passed:
// Test.expect(solution('world') == 'dlrow')