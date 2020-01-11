// Language: Javascript
// Level: 8kyu
// Name of Problem: Calculate BMI

// Instructions: Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
// if bmi <= 18.5 return "Underweight"
// if bmi <= 25.0 return "Normal"
// if bmi <= 30.0 return "Overweight"
// if bmi > 30 return "Obese"

// Solution 1 using ternary operator:
function bmi(weight, height) {
    let bmi = weight/Math.pow(height,2)
    return bmi <= 18.5 ? "Underweight" :
           bmi <= 25.0 ? "Normal" :
           bmi <= 30.0 ? "Overweight" : "Obese"
  }

// Solution 2 using switch statement:
function bmi(weight, height) {
    let result = weight/Math.pow(height,2) 
    switch(true) {
      case result <= 18.5:
        return "Underweight";
      case result <= 25:
        return "Normal";
      case result <= 30:
        return "Overweight";
      default:
        return "Obese";
    }
  }

// Solution 3 using if/else statement:
function bmi(weight, height) {
    let result = weight/Math.pow(height,2) 
   if (result <= 18.5) {
     return "Underweight";
   } else if (result <= 25) {
     return "Normal";
   } else if (result <= 30) {
     return "Overweight";
   } else {
     return "Obese";
   }
 }

// Sample Tests Passed:
// Test.assertEquals(bmi(80, 1.80), "Normal");