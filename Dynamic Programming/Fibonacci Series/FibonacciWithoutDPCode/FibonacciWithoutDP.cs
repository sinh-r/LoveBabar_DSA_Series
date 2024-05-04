public class Fib
{
    public static int GetNthFibNumber(int n)
    {
        if(n == 0 || n === 1)
        {
            return n;
        }

        return GetNthFibNumber(n-1) + GetNthFibNumber(n-2);
    }

    public static void Main(string[] args)
    {
        int n = 8;
        int ans = GetNthFibNumber(n);
        System.Console.WriteLine(ans);
    }
}