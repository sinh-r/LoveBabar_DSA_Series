class Solution:
    def bitwiseComplement(self, n: int) -> int:
        if n == 0:
            return 1
        
        count = 0
        ans = 0
        
        while n != 0:
            bit = (n & 1) ^ 1
            
            ans += (bit * 2**count)
            
            count += 1
            n = n >> 1
            
        return ans
        