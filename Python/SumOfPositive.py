# Level: 8kyu
# Name: Sum of positive
# Instructions: You get an array of numbers, return the sum of all of the positives ones.
# Example [1,-4,7,12] => 1 + 7 + 12 = 20
# Note: if there is nothing to sum, the sum is default to 0.

# Solution in Python


def positive_sum(arr):
    max_sum = 0
    for num in arr:
        # check it's positive
        if num > 0:
            # add positive numbers together
            max_sum += num
    return max_sum

# Sample Tests Passed:
# Test.describe("positive_sum")

# Test.it("works for some examples")
# Test.assert_equals(positive_sum([1,2,3,4,5]),15)
# Test.assert_equals(positive_sum([1,-2,3,4,5]),13)
# Test.assert_equals(positive_sum([-1,2,3,4,-5]),9)

# Test.it("returns 0 when array is empty")
# Test.assert_equals(positive_sum([]),0)

# Test.it("returns 0 when all elements are negative")
# Test.assert_equals(positive_sum([-1,-2,-3,-4,-5]),0)
