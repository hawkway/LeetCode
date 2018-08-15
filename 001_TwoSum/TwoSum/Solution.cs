using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = null;

            int diff;

            List<int> lsOut = null;            
            Dictionary<int, List<int>> dNums = new Dictionary<int, List<int>>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                lsOut = new List<int>();
                if (dNums.TryGetValue(n, out lsOut))
                {
                    // dict exists, add element and save
                    lsOut.Add(i);
                    dNums[n] = lsOut;
                }
                else
                {
                    List<int> lsNew = new List<int>();
                    lsNew.Add(i);
                    dNums.Add(n, lsNew);
                }
            } // load hash

            for (int i = 0; i < nums.Length; i++)
            {
                int iod = -1;
                diff = target - nums[i];

                int ioi = -1;

                lsOut = new List<int>();
                List<int> lsIndex = null;
                // see if diff is in the array
                if (dNums.TryGetValue(diff, out lsOut))
                {                    
                    lsIndex = lsOut;
                    // check to make sure it is not itself
                    if (lsIndex != null && lsIndex.Count == 1 &&
                        (i == lsIndex.FirstOrDefault()))
                    {
                        // clear list if only 1 item, ie found self
                        lsIndex = new List<int>();
                    } // if self
                } // if exists
                else
                {
                    lsIndex = new List<int>();
                } // else

                if (lsIndex.Any())
                {
                    int temp = -1;
                    temp = lsIndex.FirstOrDefault(x => x != i);
                    if (temp != -1)
                        iod = temp;
                } // if results

                if (iod != -1)
                {
                    result = new int[2];
                    result[0] = i;
                    result[1] = iod;
                    break;
                } // if diff found

            } // iterate nums
            
            if (result == null)
                result = new int[0];
            
            return result;
        } // TwoSum
    } // Solution
} // namespace