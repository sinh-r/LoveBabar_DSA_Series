#include <vector>

using namespace std;

class Solution 
{
    public:
        int peakIndexInMountainArray(vector<int>& arr) 
        {
            int beg = 0, end = arr.size() - 1;
            int mid = 0;
            
            while(beg <= end)
            {
                mid = beg + ((end - beg) / 2);
                
                if(arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                {
                    return mid;
                }
                else if(arr[mid] < arr[mid + 1])
                {
                    beg = mid + 1;
                }
                else if(arr[mid] > arr[mid + 1])
                {
                    end = mid - 1;
                }
            }
            
            return mid;
        }
};