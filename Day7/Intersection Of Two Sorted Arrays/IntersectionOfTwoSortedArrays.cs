public class Solution
{
    List<int> findArrayIntersection(List<int> arr1, int n, List<int> arr2, int m)
    {
        List<int> ans = new List<int>();
        
        int i = 0, j = 0;
        
        while(i < n && j < m)
        {
            if(arr1[i] < arr2[j])
            {
                i++;
            }
            else if(arr1[i] > arr2[j])
            {
                j++;
            }
            else
            {
                ans.Add(arr1[i]);
                i++;
                j++;
            }
        }
        
        return ans;
    }
}