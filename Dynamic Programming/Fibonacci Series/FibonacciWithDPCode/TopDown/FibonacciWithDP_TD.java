
public class Main
{
	public static void main(String[] args) 
    {
		int n = 8;
		Fib fib = new Fib(n);
        System.out.println(fib.getNthFibonacciNumber(n));
	}
}

class Fib
{
    private int[] _dp;
    
    public Fib(int n)
    {
        _dp = new int[n+1];
    }
    
    public int getNthFibonacciNumber(int n)
    {
        if(n == 1 || n == 0)
        {
            return n;
        }
        
        if(_dp[n] == 0)
        {
            _dp[n] = getNthFibonacciNumber(n-1) + getNthFibonacciNumber(n-2);
        }
        
        return _dp[n];
    }
}