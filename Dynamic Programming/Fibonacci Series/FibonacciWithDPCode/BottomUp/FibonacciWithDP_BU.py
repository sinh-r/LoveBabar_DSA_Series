class Fib:
    def __init__(self, n) -> None:
        self._dp = [-1] * (n+1)

    def getNthFibonacciNumber(self, n):
        self._dp[0] = 0
        self._dp[1] = 1
        
        for i in range(2, n+1):
            self._dp[i] = self._dp[i-1] + self._dp[i-2]

        return self._dp[n]
    

n = 8
fib = Fib(n)
print(fib.getNthFibonacciNumber(n))