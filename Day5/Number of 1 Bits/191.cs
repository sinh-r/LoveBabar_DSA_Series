public class Solution {
    public int HammingWeight(uint n) {
        var count = 0;
        
        while( n!= 0)
        {
            if(Convert.ToBoolean(n & 1))
            {
                count++;
            }
            n = n >> 1;
        }
        
        return count;
    }
}