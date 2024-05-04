class Fib:
    def __init__(self, n) -> None:
        self._dp = [-1] * n+1

    def getNthFibNumber(self, n):
        if n == 0 or n == 1:
            return n
        
        if self._dp[n] == -1:
            self._dp[n] = self.getNthFibNumber(n-1) + self.getNthFibNumber(n-2)

        return self._dp[n]


n = 8
fib = Fib(n)

print(fib.getNthFibNumber(n))