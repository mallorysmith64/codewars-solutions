// Language: Javascript
// Level: 7kyu
// Name of Problem: Remove anchor from URL

// Instructions: Complete the function/method so that it returns the url with anything after the anchor (#) removed.

// Examples:
// removeUrlAnchor('www.codewars.com#about')
// returns 'www.codewars.com'

// removeUrlAnchor('www.codewars.com?page=1') 
// returns 'www.codewars.com?page=1' 

// Solution 1:
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