# Level: 8kyu
# Name: Switch it Up!
# Instructions: When provided with a number between 0-9, return it in words.
# Input :: 1
# Output :: "One".

# Solution in Python


def switch_it_up(number):
    return {0: 'Zero', 1: 'One', 2: 'Two', 3: 'Three', 4: 'Four', 5: 'Five', 6: 'Six', 7: 'Seven', 8: 'Eight', 9: 'Nine'}[number]

# Sample Tests Passed:
# Test.describe('Example tests')
# Test.assert_equals(switch_it_up(0), "Zero")
# Test.assert_equals(switch_it_up(9), "Nine")
