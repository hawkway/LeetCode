#include <vector>
#include <cstdlib>

using namespace std;

class Solution
{

public:

    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2)
    {
        double dResult;
        vector<int> vMerge;

        if (!nums1.empty() && !nums2.empty())
            // both not empty
            dResult = MergeVectors(nums1, nums2);
        else
        {
            // one is empty
            if (!nums1.empty())
                // v2 empty
                dResult = getMedianOfVector(nums1);
            else
                // v1 empty
                dResult = getMedianOfVector(nums2);
        } // else

        return dResult;
    } // findMedianSortedArrays


private:

    double MergeVectors(vector<int> v1, vector<int> v2)
    {
        vector<int> vResult;
        vector<int>::iterator i = v1.begin();
        vector<int>::iterator j = v2.begin();

        for (; i != v1.end() || j != v2.end();)
        {
            // put elements in order
            if (i != v1.end() && *i < *j || j == v2.end())
            {
                vResult.push_back(*i);
                i++;
            }
            else if (j != v2.end())
            {
                vResult.push_back(*j);
                j++;
            }
        } // for

        return getMedianOfVector(vResult);
    } // MergeVectors

    double getMedianOfVector(vector<int>& v)
    {
        // return vector
        double dResult;
        // size type value of vector type
        vector<int>::size_type sz = v.size();

        if (sz % 2 == 0)
        {
            // get midpoint of vector
            int iMiddle = sz / 2;
            // even length, get value to left of mid
            int ii = v.at(iMiddle-1);
            int jj = v.at(iMiddle);
            dResult = (double) (ii + jj) / 2.0;
        }
        else
        {
            if (sz > 1)
                // odd length, get value at mid
                dResult = v.at(sz/2);
            else
                // edge case, one element
                dResult = v.at(0);
        }

        return  dResult;
    } // getMedianOfVector

}; // class