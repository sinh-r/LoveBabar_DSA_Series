def PositiveConversion(n):
    count = 0
    ans = 0

    while n != 0:
        bit = n & 1

        ans += (bit * 10**count)

        n = n >> 1
        count += 1
    
    return ans


n = int(input())

ans = PositiveConversion(n)

print(ans)    