using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            
            // combine two ints
            BigInteger iSum = getNum(l1) + getNum(l2);

            result = intToListNode(iSum);
            
            return result;
        } // AddTwoNumbers
        
        // iterate ListNodes to combine numbers
        private BigInteger getNum(ListNode listNode)
        {
            string num = string.Empty;
            
            List<string> lsDigits = new List<string>();
            while (listNode != null)
            {
                lsDigits.Add(listNode.val.ToString());
                listNode = listNode.next;
            }

            for (int i = lsDigits.Count - 1; i >= 0; i--)
                num += lsDigits[i];

            return BigInteger.Parse(num);
        } // combineDigits

        // convert int to ListNode
        private ListNode intToListNode(BigInteger sum)
        {
            ListNode prev = null;
            ListNode result = null;
            
            char[] arrSum = sum.ToString().ToArray();

            // make head node
            if (arrSum.Any())
                // reverse the num, so first node is last digit
                result = new ListNode(int.Parse(arrSum[arrSum.Length-1].ToString()));

            // set result as the prev node for iterating
            prev = result;

            // validate
            if (prev != null)
            {

                int iStart = -1;

                if (arrSum.Length >= 0 && arrSum.Length <= 1)
                {
                    // have first digit from above
                }
                else if (arrSum.Length > 1)
                {
                    // need to skip the 'first' digit, which is actually the last array element
                    iStart = arrSum.Length - 2;
                }

                // validate acceptable start
                if (iStart != -1)
                {
                    // process digits in sum in reverse order, skip last digit in array at start
                    for (int i = iStart; i >= 0; i--)
                    {
                        // create new ListNode with value
                        ListNode ln = new ListNode(int.Parse(arrSum[i].ToString()));
                        // set new node as the next node in linked list
                        prev.next = ln;
                        // increment 'prev' node to be the newly added node in the list
                        prev = ln;
                    } // each digit
                } // if start valid
            } // if node valid

            return result;
        } // intToListNode
    } // class
} // namespace