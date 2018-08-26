from Solution import Solution

s = Solution()

tests = [121, -121, 10]

for t in tests:
    res = s.isPalindrome(t)
    print("t: " + str(t) + " ; res: " + str(res))