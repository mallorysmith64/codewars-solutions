# Language: Python
# Level: 8kyu
# Name of Problem: L1 - Set Alarm

# Instructions: Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
# The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise.

# Examples: 
# setAlarm(true, true) -> false 
# setAlarm(false, true) -> false 
# setAlarm(false, false) -> false 
# setAlarm(true, false) -> true

# Solution:
def set_alarm(employed, vacation):
    return(employed and not vacation)

# Sample Tests Passed:
# Test.describe("set_alarm")
# Test.it("returns correct result for all input values")
# Test.assert_equals(set_alarm(True, True), False, "Fails when input is True, True")
# Test.assert_equals(set_alarm(False, True), False, "Fails when input is False, True")
# Test.assert_equals(set_alarm(False, False), False, "Fails when input is False, False")
# Test.assert_equals(set_alarm(True, False), True, "Fails when input is True, False")