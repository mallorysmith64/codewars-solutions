-- Database Language: SQL
-- Level: 8kyu
-- Name of Problem: Adults only (SQL for Beginners #1)

-- Instructions: In your application, there is a section for adults only. 
-- You need to get a list of names and ages of users from the users table, who are 18 years old or older.
-- NOTE: Your solution should use pure SQL. 
-- Ruby is used within the test cases to do the actual testing.

-- Example:
-- users table schema
-- name
-- age

-- Solution 1:
SELECT * FROM users WHERE age >= '18';

-- Sample Tests Passed:
-- results = run_sql

-- describe :users do
--    it "should return 4 users" do
--     expect(results.count).to eq 4
--    end
-- end