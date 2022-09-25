public class Solution
{
    private int findPivot(List<int> arr, int n)
    {
        int beg = 0, end = n - 1;
        int mid = -1;
        
        while(beg < end)
        {
            mid = beg + (end - beg)/ 2;
            if(arr[mid] >= arr[0])
            {
                beg = mid + 1;
            }
            else
            {
                end = mid;
            }
        }
        
        return beg;
    }

    private int search(List<int> arr, int beg, int end, int k)
    {
        int mid = -1;
        
        while(beg <= end)
        {
            mid = beg + ((end - beg)/ 2);
            
            if(arr[mid] == k)
            {
                return mid;
            }
            else if(arr[mid] > k)
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }
        
        return -1;
    }

    public int findPosition(List<int> arr, int n, int k)
    {
        // Write your code here.
        // Return the position of K in ARR else return -1.
        int lowerPivot = findPivot(arr, n);
        int ans = -1;
            
        if(arr[lowerPivot] <= k && k <= arr[n - 1])
        {
            ans = search(arr, lowerPivot, n - 1, k);
        }
        else
        {
            ans = search(arr, 0, lowerPivot, k);
        }
        
        return ans;
    }
}