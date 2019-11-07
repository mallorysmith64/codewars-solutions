# Level: 8kyu
# Name: Grasshopper - Messi goals function
# Instructions: Messi is a soccer player with goals in three leagues: LaLiga, Copa del Rey, and Champions
# Complete the function to return his total number of goals in all three leagues.
# For example: 5, 10, 2  -->  17

# solution in python


def goals(laLiga, copaDelRey, championsLeague):
    return laLiga + copaDelRey + championsLeague

# sample tests passed:
# Test.assertEquals(goals(0,0,0), 0)
# Test.assertEquals(goals(43, 10, 5), 58)
