// Language: Javascript
// Level: 8kyu
// Name: Grasshopper - Messi goals function

// Instructions: Messi is a soccer player with goals in three leagues: LaLiga, Copa del Rey, and Champions
// Complete the function to return his total number of goals in all three leagues.

// Example:
// 5, 10, 2  -->  17

// Solution:
function goals(laLigaGoals, copaDelReyGoals, championsLeagueGoals) {
  return laLigaGoals + copaDelReyGoals + championsLeagueGoals
}

// Sample Tests Passed:
// Test.assertEquals(goals(0,0,0), 0)
// Test.assertEquals(goals(43, 10, 5), 58)