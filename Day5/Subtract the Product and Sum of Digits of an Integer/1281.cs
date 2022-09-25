public class Solution {
    public int SubtractProductAndSum(int n) {
        var sum = 0;
        var product = 1;
        
        while(n != 0)
        {
            var digit = n % 10;
            
            sum += digit;
            product *= digit;
            
            n /= 10;
        }
        
        return product - sum;
    }
}