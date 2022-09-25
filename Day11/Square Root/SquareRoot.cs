public class Solution
{
    public int sqrtN(long N)
    {
        // Write your code here.
        nuint beg = 1, end = N;
        long ans = -1;
        
        
        while(beg <= end)
        {
            ans = beg + (end - beg)/ 2;
            
            if(ans * ans == N)
            {
                return ans;
            }
            else if(ans * ans > N)
            {
                end = ans - 1;
            }
            else
            {
                beg = ans + 1;
            }
        }
        
        if(ans < 0)
        {
            return 0;
        }
        else if(ans * ans > N)
        {
            return ans - 1;
        }
        
        return ans;
    }
}