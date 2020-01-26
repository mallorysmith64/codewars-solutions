# Language: Python
# Level: 7kyu
# Name of Problem: Remove Anchor From URL

# Instructions: Complete the function/method so that it returns the url with anything after the anchor (#) removed.

# Examples:
# returns 'www.codewars.com'
# remove_url_anchor('www.codewars.com#about')

# returns 'www.codewars.com?page=1' 
# remove_url_anchor('www.codewars.com?page=1')

# Solution 1:
def remove_url_anchor(url):
     return url.split("#")[0]

# Sample Tests Passed:
# Test.assert_equals(remove_url_anchor("www.codewars.com#about"), "www.codewars.com");
# Test.assert_equals(remove_url_anchor("www.codewars.com/katas/?page=1#about"), "www.codewars.com/katas/?page=1")
# Test.assert_equals(remove_url_anchor("www.codewars.com/katas/"), "www.codewars.com/katas/")