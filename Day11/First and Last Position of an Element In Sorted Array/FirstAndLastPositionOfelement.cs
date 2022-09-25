public class Solution
{
    public int search(List<int> arr, int n, int k, bool findFirst = true)
    {
        int beg = 0, end = n - 1;
        int first = -1;
        
        while(beg <= end)
        {
            int mid = beg + ((end - beg)/ 2);
            if(arr[mid] == k)
            {
                first = mid;
                if(findFirst)
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
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
        
        return first;
    }

    Tuple<int, int> firstAndLastPosition(List<int> arr, int n, int k)
    {
        int first = search(arr, n, k);
        
        if(first == -1)
        {
            return new Tuple<int, int> {first, first};
        }
        
        int last = search(arr, n, k, false);
        
        return new Tuple<int, int> {first, last};
        
    }
}