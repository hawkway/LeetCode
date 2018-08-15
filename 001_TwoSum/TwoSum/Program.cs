using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();
            
            List<Tuple<int, int[]>> lsTestData = new List<Tuple<int, int[]>>();
            
            int[] nums1 = {2, 7, 11, 15};
            int[] nums2 = {3, 3};
            int[] nums3 = {3, 2, 4};
            
            lsTestData.Add(Tuple.Create(9, nums1));
            lsTestData.Add(Tuple.Create(6, nums2));
            lsTestData.Add(Tuple.Create(6, nums3));

            foreach (var tup in lsTestData)
                sln.TwoSum(tup.Item2, tup.Item1);

        } // main
    } // class
} // namespace