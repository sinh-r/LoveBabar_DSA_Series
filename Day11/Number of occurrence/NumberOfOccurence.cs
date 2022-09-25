public class Solution
{
    private int search(int[] arr, int n, int x, bool findFirst = true)
    {
        int beg = 0, end = n - 1;
        int ans = -1;
        
        while(beg <= end)
        {
            int mid = beg + ((end - beg)/ 2);
            
            if(arr[mid] == x)
            {
                ans = mid;
                
                if(findFirst)
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
            }
            else if(arr[mid] > x)
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }
        
        return ans;
    }
	
public int count(int[] arr, int n, int x) 
{
    // code here
    int first = search(arr, n, x);
    
    if(first == -1)
    {
        return 0;
    }
    
    int last = search(arr, n, x, false);
    
    return last - first + 1;
}
}