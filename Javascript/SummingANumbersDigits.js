// Language: Javascript
// Level: 7kyu
// Name of Problem: Summing a number's digits

// Instructions: Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.
// Let's assume that all numbers in the input will be integer values.

// Examples:
//SumDigits(10)  // Returns 1
//SumDigits(99)  // Returns 18
//SumDigits(-32) // Returns 5

// Solution:
function sumDigits(number) {
    let n = 0;
    let sum = 0;
    number = Math.abs(number)
    while(number != 0)
    {
        sum += number % 10
        number = Math.floor(number/10)
    }
    return sum
}

// Sample Tests Passed:
// Test.assertEquals(sumDigits(10), 1);
// Test.assertEquals(sumDigits(99), 18);
// Test.assertEquals(sumDigits(-32), 5);