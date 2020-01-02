# Language: Python
# Level: 8kyu
# Name of Problem: I love you, a little , a lot, passionately ... not at all

# Instructions: Who remembers back to their time in the schoolyard, when girls would take a flower and tear its petals, saying each of the following phrases each time a petal was torn:
# I love you, a little, a lot, passionately, madly, not at all
# Your goal in this kata is to determine which phrase the girls would say for a flower of a given number of petals, where nb_petals > 0.

# Solution:
# subtract one from array b/c it is 0 based; girl starts counting at 1 but array starts at 0
def how_much_i_love_you(petals):
   return ['I love you', 'a little', 'a lot', 'passionately', 'madly', 'not at all'][petals % 6 - 1]

# Sample Tests Passed:
# def testing(actual, expected):
#     Test.assert_equals(actual, expected)
# Test.describe("decode")
# Test.it("Basic tests")
# testing(how_much_i_love_you(7),"I love you")
# testing(how_much_i_love_you(3),"a lot")
# testing(how_much_i_love_you(6),"not at all")