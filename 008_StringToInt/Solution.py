class Solution:
    def myAtoi(self, str):
        """
        :type str: str
        :rtype: int
        """

        # never in a million years would i write something like this professionally.

        # DuctTape++ for weird edge cases, total sln should be 10 lines using regex

        # vars
        sNumber = ""
        numFound = False
        signFound = False
        returnZero = False

        # constants
        PLUS = "+"
        MINUS = "-"
        WHITESPACE = " "
        MAX_VAL = 2147483647
        MIN_VAL = -2147483648

        for c in str:
            if not numFound:
                if not signFound and c is WHITESPACE:
                    pass
                elif (c is PLUS) or (c is MINUS):
                    if not signFound:
                        sNumber += c
                        signFound = True
                    else:
                        # two signs found
                        return 0
                elif c.isdigit():
                    # first numFound
                    sNumber += c
                    numFound = True
                else:
                    # some other non-digit, terminate
                    returnZero = True
                    break
            else:
                # one or more digits found
                if c.isdigit():
                    sNumber += c
                else:
                    # any non digit terminates
                    break

        if returnZero or sNumber == "":
            return 0
        else:
            if numFound:
                if sNumber[0] == PLUS:
                    try:
                        res = int(sNumber)
                        if res > MAX_VAL:
                            res = MAX_VAL
                        return res
                    except ValueError:
                        return MAX_VAL
                elif sNumber[0] == MINUS:
                    try:
                        res = int(sNumber)
                        if res < MIN_VAL:
                            res = MIN_VAL
                        return res
                    except ValueError:
                        return MIN_VAL
                else:
                    # still a positive num
                    try:
                        res = int(sNumber)
                        if res > MAX_VAL:
                            res = MAX_VAL
                        return res
                    except ValueError:
                        return MAX_VAL
            else:
                return 0