class Fib
{
    private int[] _dp;
    
    public Fib(int n)
    {
        _dp = new int[n+1];
    }
    
    public int getNthFibonacciNumber(int n)
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

public class Main
{
	public static void main(String[] args) 
    {
		int n = 8;
		Fib fib = new Fib(n);
        System.out.println(fib.getNthFibonacciNumber(n));
	}
}

