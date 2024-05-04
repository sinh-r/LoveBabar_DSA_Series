class Fib{
    getNthFibonacciNumber = (n: number): number => {
        if(n == 0 || n == 1){
            return n;
        }
        
        return this.getNthFibonacciNumber(n-1) + this.getNthFibonacciNumber(n-2);
    }
}