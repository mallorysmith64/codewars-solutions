// Level: 8kyu
// Name: I love you, a little , a lot, passionately ... not at all
// Instructions: Say each of the following phrases each time a petal is torn:
// I love you
// a little
// a lot
// passionately
// madly
// not at all

// Your goal in this kata is to determine which phrase someone would say for a flower of a given number of petals, where nb_petals > 0.

//Solution in Javascript
const howMuchILoveYou = petals => {
  let answer = petals % 6;
  switch (answer) {
    case 1:
      return "I love you";
    case 2:
      return "a little";
    case 3:
      return "a lot";
    case 4:
      return "passionately";
    case 5:
      return "madly";
    default:
      return "not at all";
  }
};

// Sample Tests Passed:
// function testing(actual, expected) {
//   Test.assertEquals(actual, expected)
// }
// Test.describe("howMuchILoveYou",function() {
//   Test.it("Basic tests",function() {
//       testing(howMuchILoveYou(7),"I love you")
//       testing(howMuchILoveYou(3),"a lot")
//       testing(howMuchILoveYou(6),"not at all")
// })})
