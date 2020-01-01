// Level: 7kyu
// Name: Remove anchor from URL
// Instructions: Complete the function/method so that it returns the url with anything after the anchor (#) removed.

// Examples:
// Kata.RemoveUrlAnchor("www.codewars.com#about") => "www.codewars.com"
// Kata.RemoveUrlAnchor("www.codewars.com?page=1") => "www.codewars.com?page=1"

// Solution in Javascript:
function removeUrlAnchor(url) {
    const index = url.indexOf("#");
    return index === -1 ? url : url.slice(0, index);
}

// Solution 2:
function removeUrlAnchor(url){
    return url.split("#")[0]
  }

// Sample Tests Passed:
// Test.assertEquals(removeUrlAnchor('www.codewars.com#about'), 'www.codewars.com');