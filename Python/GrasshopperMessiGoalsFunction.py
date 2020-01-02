# Language: Python
# Level: 8kyu
# Name of Problem: Grasshopper - Messi goals function

# Instructions: Messi is a soccer player with goals in three leagues: LaLiga, Copa del Rey, and Champions
# Complete the function to return his total number of goals in all three leagues.

# Example:
# 5, 10, 2  -->  17

# Solution:

def goals(laLiga, copaDelRey, championsLeague):
    return laLiga + copaDelRey + championsLeague

# Sample Tests Passed:
# Test.assert_equals(goals(0, 0, 0), 0)
# Test.assert_equals(goals(5, 10, 2), 17)