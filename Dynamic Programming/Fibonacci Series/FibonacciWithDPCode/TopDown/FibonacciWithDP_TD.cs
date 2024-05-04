public class Fib
{
    private int[] _dp;

    public Fib(int n)
    {
        _dp = new int[n+1];
        _dp[0] = 0;
        _dp[1] = 1;
    }

    public static int GetNthFibNumber(int n)
    {
        if(n == 0 || n == 1)
        {
            return n;
        }

        if(_dp[n] == 0)
        {
            _dp[n] = GetNthFibNumber(n-1) + GetNthFibNumber(n-2);
        }

        return _dp[n];
    }

    
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = 8;
        Fib fib = new (n);
        int ans = fib.GetNthFibNumber(n);
        System.Console.WriteLine(ans);
    }
}