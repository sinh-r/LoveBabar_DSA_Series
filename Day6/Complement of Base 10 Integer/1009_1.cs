public class Solution 
{
    public int BitwiseComplement(int n) 
    {
        if(n == 0)
        {
            return 1;
        }
        
        var count = 0;
        var ans = 0;
        
        while(n != 0)
        {
            var bit = (n & 1) ^ 1;
            
            ans += Convert.ToInt32((bit * Math.Ceiling(Math.Pow(2, count))));
            
            count++;
            n = n >> 1;
        }
        
        return ans;
    }
}