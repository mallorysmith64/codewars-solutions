// Language: Javascript
// Level: 8kyu
// Name of Problem: Century From Year

// Instructions: The first century spans from the year 1 up to and including the year 100, The second - from the year 101 up to and including the year 200, etc.
// Given a year, return the century.

// Examples:
// centuryFromYear(1705)  returns (18)
// centuryFromYear(1900)  returns (19)
// centuryFromYear(1601)  returns (17)
// centuryFromYear(2000)  returns (20)

// Solution 1:
const century = year => {
    return Math.floor(1 + (year - 1) / 100)
  }

// Solution 2:
function century(year) {
    let century = Math.floor(year / 100)
    let decade = year % 100

    if (decade > 0) {
    return century + 1
    }
    return century
  }

// Sample Tests Passed:
// Test.assertEquals(century(1705), 18, 'Testing for year 1705');
// Test.assertEquals(century(1900), 19, 'Testing for year 1900');
// Test.assertEquals(century(1601), 17, 'Testing for year 1601');
// Test.assertEquals(century(2000), 20, 'Testing for year 2000');
// Test.assertEquals(century(89), 1, 'Testing for year 89');