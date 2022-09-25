import sys

class Solution:
    def reverse(self, x: int) -> int:
        ans = 0
        isNegative = False
        
        if x < 0:
            isNegative = True
            x *= -1
        
        while x != 0:
            digit = x % 10
        
            if (ans > (2**31 - 1) // 10) or (ans < (-2**31) // 10):
                return 0
        
            ans = ans * 10 + digit
            
            x //= 10
        
        if isNegative:
            ans *= -1
            
        return ans
        