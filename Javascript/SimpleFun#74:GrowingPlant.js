// Language: Javascript
// Level: 
// Name of Problem: 

// Instructions: 

// Examples:


// Solution 1 using while loop and if statement:
function growingPlant(upSpeed, downSpeed, desiredHeight) {
    let height = 0, day = 0;
    while (height < desiredHeight) {
    height += upSpeed;
    day+=1;
      if (height < desiredHeight)
      height -= downSpeed;
    }
      return day;
  }

// Solution 2 same as Solution 1 but with day++ in different location:
function growingPlant(upSpeed, downSpeed, desiredHeight) {
    let height = 0;
    let day = 0;
    while (height < desiredHeight) {
      height += upSpeed;
      if (height < desiredHeight)
      height -= downSpeed;
      day++;
      }
    return day; 
  }

// Solution 3 using for loop and if/else statement:
function growingPlant(upSpeed, downSpeed, desiredHeight) {
    let height = 0;
    for (let i = 1; height <= desiredHeight; i++) {
    height+=upSpeed;
      if (height >= desiredHeight) {
      return i;
      } else {
      height -= downSpeed;
      }
    }
  }

// Solution 4 using for loop and if/else statement:
function growingPlant(upSpeed, downSpeed, desiredHeight) {
    let height = 0;
    for (var i = 1;; i++) {
    height += upSpeed;
      if (height >= desiredHeight) {
      break;
      } else {
      height-=downSpeed;
      }
    }
    return i;
  }

// Sample Tests Passed:
// describe("Basic Tests", function(){
//     it("It should works for basic tests.", function(){
//     Test.assertEquals(growingPlant(100,10,910),10)
//     Test.assertEquals(growingPlant(10,9,4),1)
// })})