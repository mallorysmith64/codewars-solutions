// Language: Javascript
// Level: 7kyu
// Name of Problem: Shortest Word

// Instructions: Simple, given a string of words, return the length of the shortest word(s).
// String will never be empty and you do not need to account for different data types.

// Solution 1 using split(), sort(), and pop():
function findShort(s){
  return s.split(' ').sort((a,b) => (b.length - a.length)).pop().length
}

// Solution 2:
function findShort(s){
  let arr = s.split(' ')
  let shortest = arr[0]
    for (let i = 0; i < arr.length; i++) {
    if (arr[i].length < shortest.length) {
  shortest = arr[i]
    }
  }
return shortest.length;
}

// Solution 3 using Infinity:
const findShort = s => {
  let wordArr = s.split(' ')
  let shortest = Infinity
  for (let i = 0; i < wordArr.length; i++) {
    let wordLength = wordArr[i].length
    if (wordLength < shortest) {
      shortest = wordLength
    }
  }
  return shortest
}

// Sample Tests Passed:
// Test.describe("Example tests",_=>{
//   Test.assertEquals(findShort("bitcoin take over the world maybe who knows perhaps"), 3);
//   Test.assertEquals(findShort("turns out random test cases are easier than writing out basic ones"), 3);
//   });