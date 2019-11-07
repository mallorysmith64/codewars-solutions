// Level: 8kyu
// Name: Convert a String to a Number!
// Instructions: Transform a string into a number

//Solution in Javascript
const stringToNumber = str => {
  let num = parseInt(str)
  return num
}

// Sample Tests Passed:
// describe( "stringToNumber", function(){
//   it( "should work for the examples" , function(){
//     Test.assertEquals(stringToNumber("1234"),1234)
//     Test.assertEquals(stringToNumber("605"), 605)
//     Test.assertEquals(stringToNumber("1405"),1405)
//     Test.assertEquals(stringToNumber("-7"),  -7)
//   });
// });
