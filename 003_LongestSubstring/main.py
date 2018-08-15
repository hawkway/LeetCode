from Solution import Solution

sln = Solution()

testData = ["aabaab!bb", " ", "abcabcbb", "bbbbb", "pwwkew"]

for t in testData:
    res = sln.lengthOfLongestSubstring(t)
    print("max of '" + t + "' is: " + str(res))