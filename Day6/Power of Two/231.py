class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        power = 1
        
        for i in range(0, 30):
            if n == power:
                return True
            
            power *= 2
            
        if n == power:
            return True
        
        return False
        