int sqrtN(long long int N)
{
    // Write your code here.
    unsigned int beg = 1, end = N;
    long long int ans = -1;
    
    
    while(beg <= end)
    {
        ans = beg + (end - beg)/ 2;
        
        if(ans * ans == N)
        {
            return ans;
        }
        else if(ans * ans > N)
        {
            end = ans - 1;
        }
        else
        {
            beg = ans + 1;
        }
    }
    
    if(ans < 0)
    {
        return 0;
    }
    else if(ans * ans > N)
    {
        return ans - 1;
    }
    
    return ans;
}

double precisionValue(int n, int precision, int integerValue)
{
    double ans = integerValue;
    double factor = 1;

    for(int i = 1; i <= precision; i++)
    {
        factor = factor / 10;

        for(int j = ans; j * j <= n; j += factor)
        {
            ans = j;
        }
    }

    return ans;
}