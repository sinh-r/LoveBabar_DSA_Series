public class Solution 
{
    public int BitwiseComplement(int n) 
    {
        if(n == 0)
        {
            return 1;
        }
        
        var m = n;
        var mask = 0;
        
        while(m != 0)
        {
            mask = (mask << 1) | 1;
            m = m >> 1;
        }
        
        var ans = (~n) & mask;
        
        return ans;
    }
}