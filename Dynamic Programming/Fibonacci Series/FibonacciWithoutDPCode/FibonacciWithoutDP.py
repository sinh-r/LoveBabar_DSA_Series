def getNthFibNumber(n):
    if n == 0 or n == 1:
        return n
    return getNthFibNumber(n-1) + getNthFibNumber(n-2)

n = 8
print(getNthFibNumber(n))