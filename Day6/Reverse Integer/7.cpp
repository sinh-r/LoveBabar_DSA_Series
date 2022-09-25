#include <cmath>

class Solution {
public:
    int reverse(int x) {
        int ans = 0;
        int count = 0;
        
        //These were declared becuase VSCode could not find INT_MAX and INT_MIN
        int INT_MAX = pow(2, 31) - 1;
        int INT_MIN = pow(-2, 31);

        while(x != 0)
        {
            int digit = x % 10;
            
            if(ans > INT_MAX/10 || ans < INT_MIN/10)
            {
                return 0;
            }
            
            ans = ans * 10 + digit;
            
            count ++;
            x /= 10;
        }
        
        return ans;
    }
};