# Level: 8kyu
# Name: Basic Mathematical Operations
# Instructions: Your task is to create a function that does four basic mathematical operations.
# The function should take three arguments - operation(string/char), value1(number), value2(number).
# The function should return result of numbers after applying the chosen operation.

# Examples:
# basicOp('+', 4, 7)         // Output: 11
# basicOp('-', 15, 18)       // Output: -3
# basicOp('*', 5, 5)         // Output: 25
# basicOp('/', 49, 7)        // Output: 7

# Solution 1 in Python


def basic_op(operator, value1, value2):
    return {'+': value1 + value2, '-': value1 - value2, '*': value1 * value2, '/': value1 / value2}[operator]

# Solution 2 in Python


def basic_op(operator, a, b):
    return {'+': a + b, '-': a - b, '*': a * b, '/': a / b}[operator]

# Sample Tests Passed:
# Test.describe("Basic tests")
# Test.assert_equals(basic_op('+', 4, 7), 11)
# Test.assert_equals(basic_op('-', 15, 18), -3)
# Test.assert_equals(basic_op('*', 5, 5), 25)
# Test.assert_equals(basic_op('/', 49, 7), 7)
