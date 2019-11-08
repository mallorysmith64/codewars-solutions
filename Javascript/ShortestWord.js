// Level: 7kyu
// Name: Shortest Word
// Instructions: Simple, given a string of words, return the length of the shortest word(s).
// String will never be empty and you do not need to account for different data types.

// Solution in Javascript
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
