class Fib
{
    private int[] _dp;

    public Fib(int n)
    {
        _dp = new int[n+1];
    }

    public int GetNthFibonacciNumber(int n)
    {
        _dp[0] = 0;
        _dp[1] = 1;

        for(int i = 2; i < n+1; i++)
        {
            _dp[i] = _dp[i-1] + _dp[i-2];
        }

        return _dp[n];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int n = 8;
        Fib fib = new (n);
        fib.GetFibonacciNumber(n);
    }
}