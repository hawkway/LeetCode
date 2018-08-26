class Solution:
    def RemoveZero(self, s):
        if len(s) > 0 and s[0] == "0":
            return s[1:]

    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        res = 0
        sNum = str(x)
        lenEven = True
        isSignPos = True
        MAX_VAL = 2147483647
        MIN_VAL = -2147483648

        # find sign
        if len(sNum) > 0 and sNum[0] == "-":
            isSignPos = False
            sNum = sNum[1:]
        elif len(sNum) > 0 and sNum[0] == "+":
            sNum = sNum[1:]

        # create result array
        sResult = [""] * len(sNum)

        # find length of string
        if len(sNum) % 2 != 0:
            lenEven = False

        # end pointer
        i = 0
        j = len(sNum)-1
        # from both ends to middle, swap digits
        while i <= j:
            # set ending criteria
            if (lenEven and i < j):
                # set last digit to first
                sResult[i] = sNum[j]
                # set first digit to last
                sResult[j] = sNum[i]
                # move pointer
                i += 1
                j -= 1
            elif (not lenEven and i != j):
                # set last digit to first
                sResult[i] = sNum[j]
                # set first digit to last
                sResult[j] = sNum[i]
                # move pointer
                i += 1
                j -= 1
            elif (not lenEven and i == j):
                # set middle digit
                sResult[i] = sNum[i]
                i += 1
                j -= 1

        # turn array into a string
        sNum = ''.join(sResult)

        # remove all leading zeroes
        while sNum != "" and sNum[0] == "0":
            sNum = self.RemoveZero(sNum)

        if isSignPos and len(sNum) > 0:
            res = int(sNum)
            if res > MAX_VAL:
                res = 0
        else:
            if len(sNum) > 0:
                res = int("-" + sNum)
                if res < MIN_VAL:
                    res = 0

        return res
