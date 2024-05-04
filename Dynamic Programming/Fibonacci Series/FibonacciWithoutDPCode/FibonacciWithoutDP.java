public class Fib
{
    public static int getNthFibonacciNumber(int n)
    {
        if(n == 1 || n == 0)
        {
            return n;
        }

        return getNthFibonacciNumber(n-1) + getNthFibonacciNumber(n-2);
    }

    public static void main(String[] args)
    {
        int n = 8;
        System.out.println(getNthFibonacciNumber(n));
    }
}