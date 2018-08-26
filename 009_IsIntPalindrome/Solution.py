class Solution:
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """

        result = True
        sNum = str(x)

        # init pointers
        i = 0
        j = len(sNum) - 1

        # start at ends of number
        while i <= j:
            # if digits don't match, exit
            if sNum[i] != sNum[j]:
                result = False
                break
            else:
                # move pointers to check next digit
                i += 1
                j -= 1

        # return results
        return result