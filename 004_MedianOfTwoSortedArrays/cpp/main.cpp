#include <vector>
#include "Solution.cpp"
using namespace std;

int main()
{
    vector<int> v1;
    vector<int> v2;
    Solution sln;

    // load v1
    //v1.push_back(1);
    //v1.push_back(2);

    // load v2
    //v2.push_back(3);
    //v2.push_back(4);

    v1.push_back(1);
    v1.push_back(3);

    v2.push_back(2);

    double d = sln.findMedianSortedArrays(v1, v2);

    return 0;
}