#include <math.h>

class Solution 
{
    public:
        int bitwiseComplement(int n) 
        {
            int ans = 0;
            int count = 0;
            
            if(n == 0)
            {
                return 1;
            }
            
            while(n!= 0)
            {
                int bit = (n & 1) ^ 1;
                
                ans += (bit * ceil(pow(2, count)));
                
                count++;
                n = n >> 1;
            }
            
            return ans;
        }
};