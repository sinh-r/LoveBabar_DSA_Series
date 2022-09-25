public class Solution
{
    int findDuplicate(List<int> arr) 
    {
        // Write your code here
        int ans = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            ans = ans ^ arr[i];
        }
        
        for(int i = 1; i < arr.size(); i++)
        {
            ans = ans ^ i;
        }
        
        return ans;
    }
}