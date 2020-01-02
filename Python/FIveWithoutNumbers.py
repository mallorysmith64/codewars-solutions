# Language: Python
# Level: 8kyu
# Name of Problem: 5 Without Numbers

# Instructions: Write a function that always returns 5
# Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/

# Solution 1:

def unusual_five():
     return len("hello")

# Solution 2:

# def unusual_five():
#     unusual_five = ""
#     return len("aaaaa")

# Sample Tests Passed:
# test.describe("Basic test")
# test.it("Should return 5")
# test.assert_equals(unusual_five(),5,"lol")