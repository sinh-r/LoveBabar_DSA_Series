public class Solution {
    public int Reverse(int x) {
        var ans = 0;
        
        while(x != 0)
        {
            var digit = x % 10;
            
            if(ans > Int32.MaxValue/10 || ans < Int32.MinValue/10)
            {
                return 0;
            }
            
            ans = ans * 10 + digit;
            
            x /= 10;
        }
        
        return ans;
    }
}