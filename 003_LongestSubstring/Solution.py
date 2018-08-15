class Solution:
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """

        iMaxLength = 0
        iCurrLength = 0
        currSubStr = []

        # for each char in string
        for i, c in enumerate(s):
            # if not dupe char
            if c not in currSubStr:
                # add to list
                currSubStr.append(c)
                # increment length
                iCurrLength += 1
            else:
                # add curr element to end
                currSubStr.append(c)
                # find first dupe char
                removeIndex = currSubStr.index(c)
                # keep everything after remove index
                currSubStr = currSubStr[removeIndex+1:]
                # update max?
                if iCurrLength > iMaxLength:
                    # update max
                    iMaxLength = iCurrLength
                # curr len is now len(set)
                iCurrLength = len(currSubStr)
        # return max

        # update max?
        if iCurrLength > iMaxLength:
            # update max
            iMaxLength = iCurrLength

        return  iMaxLength