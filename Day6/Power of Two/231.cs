public class Solution 
{
    public bool IsPowerOfTwo(int n) 
    {
        int power = 1;
            
        for(int i = 0; i < 30; i++)
        {
            if(power == n)
            {
                return true;
            }

            power *= 2;
        }

        if(power == n)
        {
            return true;
        }

        return false;    
    }
}