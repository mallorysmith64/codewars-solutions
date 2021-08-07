// Language: Javascript
// Level: 7kyu
// Name of Problem: List Filtering

/* 
Instructions:
In this kata you will create a function that takes a list of non-negative integers and strings 
and returns a new list with the strings filtered out.

Example:
filter_list([1,2,'a','b']) == [1,2]
filter_list([1,'a','b',0,15]) == [1,0,15]
filter_list([1,2,'aasf','1','123',123]) == [1,2,123]
*/

// Solution:
function filter_list(l) {
  return (list = l.filter(Number.isInteger));
}

// Sample Tests Passed
// describe("Tests", () => {
//     it("test", () => {
//   Test.assertSimilar(filter_list([1,2,'a','b']),[1,2])
//   Test.assertSimilar(filter_list([1,'a','b',0,15]),[1,0,15])
//   Test.assertSimilar(filter_list([1,2,'aasf','1','123',123]),[1,2,123])
//     });
//   });
