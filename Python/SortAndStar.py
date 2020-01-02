# Language: Python
# Level: 8kyu
# Name of Problem: Sort and Star

# Instructions: You will be given an vector of string(s). You must sort it alphabetically (case-sensitive!!) and then return the first value.
# The returned value must be a string, and have "***" between each of its letters.
# You should not remove or add elements from/to the array.

# Solution 1:

def two_sort(array):
    return '***'.join(list(sorted(array)[0]))

# Solution 2:

# def two_sort(array):
#     return '***'.join(min(array))

# Sample Tests Passed:
# Test.assert_equals(two_sort(["bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"]), 'b***i***t***c***o***i***n' )
# Test.assert_equals(two_sort(["turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones"]), 'a***r***e')
# Test.assert_equals(two_sort(["lets", "talk", "about", "javascript", "the", "best", "language"]), 'a***b***o***u***t')
# Test.assert_equals(two_sort(["i", "want", "to", "travel", "the", "world", "writing", "code", "one", "day"]), 'c***o***d***e')
# Test.assert_equals(two_sort(["Lets", "all", "go", "on", "holiday", "somewhere", "very", "cold"]), 'L***e***t***s')