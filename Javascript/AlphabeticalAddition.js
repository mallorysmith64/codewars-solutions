// Language: Javascript
// Level: 7kyu
// Name of Problem: Alphabetical Addition

// Instructions: Your task is to add up letters to one letter.
// The function will be given a variable amount of arguments, each one being a letter to add.
// Letters will always be lowercase.
// Letters can overflow (see second to last example of the description)
// If no letters are given, the function should return 'z'

// Examples:
// addLetters('a', 'b', 'c') = 'f'
// addLetters('a', 'b') = 'c'
// addLetters('z') = 'z'
// addLetters('z', 'a') = 'a'
// addLetters('y', 'c', 'b') = 'd' // notice the letters overflowing
// addLetters() = 'z'

// Solution 1:
function addLetters(...letters) {
    const alpha = 'zabcdefghijklmnopqrstuvwxy'
    const sum = letters.reduce((sum, letter) => sum + alpha.indexOf(letter), 0) % 26
    return alpha[sum]
  }

// Solution 2:
function addLetters(...letters) {
    if (letters.length === 0) {
      return 'z';
    }
  
    const numbers = letters.map(letter => {
      return letter.charCodeAt() - 96;
    });
    
    const sum = numbers.reduce((a, n) => a + n, 0);
    
    let corrected = sum;
    while (corrected > 26) {
      corrected -= 26;
    }
    
    const newLetter = String.fromCharCode(corrected + 96);
    
    return newLetter;
  }

// Sample Tests Passed:
// const { assert } = require('chai');

// describe("Fixed tests", () => {
//   const tests = [
//     [['a', 'b', 'c'], 'f'],
//     [['z'], 'z'],
//     [['a', 'b'], 'c'],
//     [['c'], 'c'],
//     [['z', 'a'], 'a'],
//     [['y', 'c', 'b'], 'd'],
//     [[], 'z']
//   ];
//   tests.forEach(test => {
//     const str = test[0].map(x => `"${x}"`).join(', ');
//     it(`addLetters(${str})`, () => {
//       assert.strictEqual(addLetters(...test[0]), test[1]);
//     });
//   });
// });