// Language: Javascript
// Level: 8kyu
// Name of Problem: Tip Calculator

// Instructions: Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.
// Because you're a nice person, you always round up the tip, regardless of the service.

// You need to consider the following ratings:
// Terrible: tip 0%
// Poor: tip 5%
// Good: tip 10%
// Great: tip 15%
// Excellent: tip 20%

// The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:
// "Rating not recognised" in Javascript, Python and Ruby...
// ...or null in Java
// ...or -1 in C#

// Solution 1:
function calculateTip(amount, rating) {
    switch(rating.toLowerCase()) {
      case 'terrible':
        return Math.ceil(amount * 0)
      case 'poor':
        return Math.ceil(amount * 0.05)
      case 'good':
        return Math.ceil(amount * 0.10)
      case 'great':
        return Math.ceil(amount * 0.15)
      case 'excellent':
        return Math.ceil(amount * 0.20)
      default:
        return 'Rating not recognised'
    }
  }

// Sample Tests Passed:
// Test.assertEquals(calculateTip(20, "Excellent"), 4);
// Test.assertEquals(calculateTip(26.95, "good"), 3);