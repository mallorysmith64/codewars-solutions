# Language: Python
# Level: 8kyu
# Name of Problem: Surface Area And Volume of A Box

# Instructions: Write a function that returns the total surface area and volume of a box as an array: [area, volume]

# Solution:

def get_size(w, h, d):
    area = (w * d + d * h + w * h) * 2
    volume = w * h * d
    return [area, volume]

# Sample Tests Passed:
# Test.assert_equals(get_size(4, 2, 6), [88,48])
# Test.assert_equals(get_size(1, 1, 1), [6,1])
# Test.assert_equals(get_size(1, 2, 1), [10,2])
# Test.assert_equals(get_size(1, 2, 2), [16,4])
# Test.assert_equals(get_size(10, 10, 10), [600,1000])